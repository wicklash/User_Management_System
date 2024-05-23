using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salary_calculate
{
    public partial class salary_calculator : Form
    {
        private const double BASE_MINIMUM_SALARY = 13414.50 * 2; // Asgari Ücret * 2
        public salary_calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseSalary = BASE_MINIMUM_SALARY;
            double calculatedSalary = CalculateMinimumSalary(baseSalary, comboBoxUserType.SelectedItem.ToString());
            labelCalculatedSalary.Text = "Hesaplanan Maaş: " + calculatedSalary.ToString("C2");
        }
        private double CalculateMinimumSalary(double baseSalary, string userType)
        {
            // BMO minimum maaş hesaplama kuralları uygulanıyor
            double minimumSalary = baseSalary;
            double coefficientSum = 0;

            // Part-time kullanıcılar için maaş %50 azaltılır
            if (userType == "Part-time")
            {
                minimumSalary *= 0.5;
            }

            // Deneyim süresi katsayısı
            int experienceYears = (int)numericUpDownExperience.Value;
            if (experienceYears >= 2 && experienceYears <= 4)
                coefficientSum += 0.60;
            else if (experienceYears >= 5 && experienceYears <= 9)
                coefficientSum += 1.00;
            else if (experienceYears >= 10 && experienceYears <= 14)
                coefficientSum += 1.20;
            else if (experienceYears >= 15 && experienceYears <= 20)
                coefficientSum += 1.35;
            else if (experienceYears > 20)
                coefficientSum += 1.50;

            // Yaşanılan il grubu katsayısı
            string cityGroup = comboBoxCityGroup.SelectedItem.ToString();
            switch (cityGroup)
            {
                case "TR10: İstanbul":
                    coefficientSum += 0.30;
                    break;
                case "TR51: Ankara":
                    coefficientSum += 0.20;
                    break;
                case "TR31: İzmir":
                    coefficientSum += 0.20;
                    break;
                case "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova":
                    coefficientSum += 0.10;
                    break;
                case "TR21: Edirne, Kırklareli, Tekirdağ":
                    coefficientSum += 0.10;
                    break;
                case "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane":
                    coefficientSum += 0.05;
                    break;
                case "TR41: Bursa, Eskişehir, Bilecik":
                    coefficientSum += 0.05;
                    break;
                case "TR32: Aydın, Denizli, Muğla":
                    coefficientSum += 0.05;
                    break;
                case "TR62: Adana, Mersin":
                    coefficientSum += 0.05;
                    break;
                case "TR22: Balıkesir, Çanakkale":
                    coefficientSum += 0.05;
                    break;
                case "TR61: Antalya, Isparta, Burdur":
                    coefficientSum += 0.05;
                    break;
                case "Diğer İller":
                    coefficientSum += 0.00;
                    break;
            }

            // Akademik derece katsayısı
            string academicDegree = comboBoxAcademicDegree.SelectedItem.ToString();
            switch (academicDegree)
            {
                case "Meslek alanı ile ilgili yüksek lisans":
                    coefficientSum += 0.10;
                    break;
                case "Meslek alanı ile ilgili doktora":
                    coefficientSum += 0.30;
                    break;
                case "Meslek alanı ile ilgili doçentlik":
                    coefficientSum += 0.35;
                    break;
                case "Meslek alanı ile ilgili olmayan yüksek lisans":
                    coefficientSum += 0.05;
                    break;
                case "Meslek alanı ile ilgili olmayan doktora/doçentlik":
                    coefficientSum += 0.15;
                    break;
            }

            // Yabancı dil bilgisi katsayısı
            if (checkBoxEnglishCertified.Checked)
                coefficientSum += 0.20;
            if (checkBoxEnglishEducated.Checked)
                coefficientSum += 0.20;
            int otherLanguages;
            if (int.TryParse(textBoxOtherLanguages.Text, out otherLanguages))
                coefficientSum += otherLanguages * 0.05;

            // Yöneticilik görevi katsayısı
            string managementRole = comboBoxManagementRole.SelectedItem.ToString();
            switch (managementRole)
            {
                case "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı":
                    coefficientSum += 0.50;
                    break;
                case "Proje Yöneticisi":
                    coefficientSum += 0.75;
                    break;
                case "Direktör/Projeler Yöneticisi":
                    coefficientSum += 0.85;
                    break;
                case "CTO/Genel Müdür":
                    coefficientSum += 1.00;
                    break;
                case "Bilgi İşlem Sorumlusu/Müdürü (en çok 5 bilişim personeli)":
                    coefficientSum += 0.40;
                    break;
                case "Bilgi İşlem Sorumlusu/Müdürü (5'ten çok bilişim personeli)":
                    coefficientSum += 0.60;
                    break;
            }

            // Aile durumu katsayısı
            if (checkBoxSpouseNotWorking.Checked)
                coefficientSum += 0.20;

            int numChildren;
            if (int.TryParse(textBoxNumChildren.Text, out numChildren))
            {
                if (checkBoxChildUnder6.Checked)
                    coefficientSum += 0.20;
                if (checkBoxChild7to18.Checked)
                    coefficientSum += 0.30;
                if (checkBoxChildOver18.Checked)
                    coefficientSum += 0.40;
            }

            // Minimum maaş hesaplanıyor
            return minimumSalary * (1 + coefficientSum);
        }

        private void checkBoxHasChildren_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumChildren.Enabled = checkBoxHasChildren.Checked;
            checkBoxChildUnder6.Enabled = checkBoxHasChildren.Checked;
            checkBoxChild7to18.Enabled = checkBoxHasChildren.Checked;
            checkBoxChildOver18.Enabled = checkBoxHasChildren.Checked;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxUserType.Items.Add("Full-time");
            comboBoxUserType.Items.Add("Part-time");
            
            
            comboBoxCityGroup.Items.AddRange(new string[]
            {
                "TR10: İstanbul",
                "TR51: Ankara",
                "TR31: İzmir",
                "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova",
                "TR21: Edirne, Kırklareli, Tekirdağ",
                "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane",
                "TR41: Bursa, Eskişehir, Bilecik",
                "TR32: Aydın, Denizli, Muğla",
                "TR62: Adana, Mersin",
                "TR22: Balıkesir, Çanakkale",
                "TR61: Antalya, Isparta, Burdur",
                "Diğer İller"
            });

            comboBoxAcademicDegree.Items.AddRange(new string[]
            {
                "Meslek alanı ile ilgili yüksek lisans",
                "Meslek alanı ile ilgili doktora",
                "Meslek alanı ile ilgili doçentlik",
                "Meslek alanı ile ilgili olmayan yüksek lisans",
                "Meslek alanı ile ilgili olmayan doktora/doçentlik",
                "Yok"
            });

            comboBoxManagementRole.Items.AddRange(new string[]
            {
                "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı",
                "Proje Yöneticisi",
                "Direktör/Projeler Yöneticisi",
                "CTO/Genel Müdür",
                "Bilgi İşlem Sorumlusu/Müdürü (en çok 5 bilişim personeli)",
                "Bilgi İşlem Sorumlusu/Müdürü (5'ten çok bilişim personeli)",
                "Yok"
            });
            comboBoxUserType.SelectedIndex = 0;
            comboBoxAcademicDegree.SelectedIndex = 5;
            comboBoxCityGroup.SelectedIndex = 0;
            comboBoxManagementRole.SelectedIndex = 6;
        }

        private void textBoxOtherLanguages_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChildUnder6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChild7to18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChildOver18_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
