using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Resources;

namespace HolmesRestorationManagementSystem.Ui
{
    public partial class HelpScreen : Form
    {
        string Title;
        string Company;
        string Version;
        string Copyright;
        string Product;
        string Description;

        public HelpScreen()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpScreen_Load(object sender, EventArgs e)
        {
            GetAssemblyInfo();
            SetHelpInfo();
        }
        private void SetHelpInfo()
        {
            if (!string.IsNullOrEmpty(Title))
                TitleLbl.Text = Title;
            if (!string.IsNullOrEmpty(Company))
                CompanyLbl.Text = $"{Company} Software Development, LLC.";
            if (!string.IsNullOrEmpty(Version))
                VersionLbl.Text = Version;
            if (!string.IsNullOrEmpty(Copyright))
                CopyrightLbl.Text = Copyright;
            if (!string.IsNullOrEmpty(Product))
                DescriptTxt.Text = Product + "\n";
            if (!string.IsNullOrEmpty(Description))
                DescriptTxt.Text = Description +"\nContact: ZStackInc@outlook.com";
        }
        private void GetAssemblyInfo()
        {
            Title = GetAssemblyTitle();
            Company = GetAssemblyCompanyName();
            Version = GetAssemblyVersion();
            Copyright = GetAssemblyCopyright();
            Product = GetAssemblyProduct();
            Description = GetAssemblyDescription();
        }
        private static string GetAssemblyTitle()
        {
            Assembly assmbly = System.Reflection.Assembly.GetEntryAssembly();
            string title = string.Empty;

            if (assmbly != null)
            {
                object[] customAttb = assmbly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if(customAttb != null && customAttb.Length > 0)
                {
                    title = ((AssemblyTitleAttribute)customAttb[0]).Title;
                }
                if(string.IsNullOrEmpty(title))
                {
                    title = string.Empty;
                }
            }

            return title;
        }
        private static string GetAssemblyCompanyName()
        {
            Assembly assmbly = System.Reflection.Assembly.GetEntryAssembly();
            string cName = string.Empty;

            if (assmbly != null)
            {
                object[] customAttb = assmbly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (customAttb != null && customAttb.Length > 0)
                {
                    cName = ((AssemblyCompanyAttribute)customAttb[0]).Company;
                }
                if (string.IsNullOrEmpty(cName))
                {
                    cName = string.Empty;
                }
            }

            return cName;
        }
        private static string GetAssemblyVersion()
        {
            Assembly assmbly = System.Reflection.Assembly.GetEntryAssembly();
            string version = string.Empty;

            if(assmbly != null)
            {
                object[] customAttb = assmbly.GetCustomAttributes(typeof(AssemblyVersionAttribute), false);
                if(customAttb != null && customAttb.Length > 0)
                {
                    version = ((AssemblyVersionAttribute)customAttb[0]).Version;
                }
                if(string.IsNullOrEmpty(version))
                {
                    version = string.Empty;
                }
            }

            return version;
        }
        private static string GetAssemblyCopyright()
        {
            Assembly assmbly = System.Reflection.Assembly.GetEntryAssembly();
            string copyright = string.Empty;

            if (assmbly != null)
            {
                object[] customAttb = assmbly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (customAttb != null && customAttb.Length > 0)
                {
                    copyright = ((AssemblyCopyrightAttribute)customAttb[0]).Copyright;
                }
                if (string.IsNullOrEmpty(copyright))
                {
                    copyright = string.Empty;
                }
            }

            return copyright;
        }
        private static string GetAssemblyProduct()
        {
            Assembly assmbly = System.Reflection.Assembly.GetEntryAssembly();
            string product = string.Empty;

            if (assmbly != null)
            {
                object[] customAttb = assmbly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (customAttb != null && customAttb.Length > 0)
                {
                    product = ((AssemblyProductAttribute)customAttb[0]).Product;
                }
                if (string.IsNullOrEmpty(product))
                {
                    product = string.Empty;
                }
            }

            return product;
        }
        private static string GetAssemblyDescription()
        {
            Assembly assmbly = System.Reflection.Assembly.GetEntryAssembly();
            string descript = string.Empty;

            if (assmbly != null)
            {
                object[] customAttb = assmbly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (customAttb != null && customAttb.Length > 0)
                {
                    descript = ((AssemblyDescriptionAttribute)customAttb[0]).Description;
                }
                if (string.IsNullOrEmpty(descript))
                {
                    descript = string.Empty;
                }
            }

            return descript;
        }
    }
}
