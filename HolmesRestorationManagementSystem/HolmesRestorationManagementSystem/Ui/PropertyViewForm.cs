using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HolmesRestorationManagementSystem.Business_Objects;
using HolmesRestorationManagementSystem.Data_Access_Layer;

namespace HolmesRestorationManagementSystem.Ui
{
    public partial class PropertyViewForm : Form
    {
        string title = "Holmes Management System";
        List<Property> AllProperties = new List<Property>();
        List<TruthValues> Truths1 = new List<TruthValues>();
        List<TruthValues> Truths2 = new List<TruthValues>();
        List<Fencing> FencingTypes = new List<Fencing>();
        List<Parking> ParkingTypes = new List<Parking>();
        List<Heating> HeatingTypes = new List<Heating>();
        List<Cooling> CoolingType = new List<Cooling>();
        List<WorkNeeded> PropertyWork = new List<WorkNeeded>();
        Property SelectedProperty;
        Property OrginalProperty;
        (bool, string) IsValid;
        bool SelectedImg = false;
        Image ImgDefault = Image.FromFile(@"C: \Users\Apex1\source\Holmes\DataFiles\defaultHouse.png");
        byte[] BinaryImg;
        string OrginalWork = null;
        bool WorkChanged = false;

        public PropertyViewForm()
        {
            InitializeComponent();
        }
        private void PropertyViewForm_Load(object sender, EventArgs e)
        {
            AllProperties = PropertyDB.GetProperties();
            PropertiesCB.DataSource = AllProperties;
            PropertiesCB.DisplayMember = "Address";
            PropertiesCB.ValueMember = "Property_Id";

            Truths1 = TruthValuesDB.GetTruthValues();
            Truths2 = TruthValuesDB.GetTruthValues();
            OccupiedCB.DataSource = Truths1;
            OccupiedCB.DisplayMember = "Truth_Value";
            OccupiedCB.ValueMember = "Id";
            RentalCB.DataSource = Truths2;
            RentalCB.DisplayMember = "Truth_Value";
            RentalCB.ValueMember = "Id";

            FencingTypes = FenceDB.GetFencingInfo();
            FencedCB.DataSource = FencingTypes;
            FencedCB.DisplayMember = "Fence_Type";
            FencedCB.ValueMember = "Id";

            ParkingTypes = ParkingDB.GetParking();
            ParkingCB.DataSource = ParkingTypes;
            ParkingCB.DisplayMember = "Parking_Type";
            ParkingCB.ValueMember = "Id";

            HeatingTypes = HeatingDB.GetHeatingInfo();
            HeatingCB.DataSource = HeatingTypes;
            HeatingCB.DisplayMember = "Heating_Type";
            HeatingCB.ValueMember = "Id";

            CoolingType = CoolingDB.GetCoolingInfo();
            CoolingCB.DataSource = CoolingType;
            CoolingCB.DisplayMember = "Cooling_Type";
            CoolingCB.ValueMember = "Id";

        }

        private void BackItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            EnableControls();
            OrginalProperty = SelectedProperty.CopyProperty();
        }
        private void EnableControls()
        {
            PropertyIdTxt.ReadOnly = true;
            PreopretyNumTxt.ReadOnly = false;
            addressTxt.ReadOnly = false;
            numRoomTxt.ReadOnly = false;
            numBathsTxt.ReadOnly = false;
            Price.ReadOnly = false;
            RentTxt.ReadOnly = false;
            WorkTxt.ReadOnly = false;
            AcceptBtn.Enabled = true;
            AcceptBtn.Visible = true;
        }
        // unable controls
        private (bool, string) CheckEdit(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(PropertyIdTxt.Text))
            {
                valid = false;
                emsg = "Id cannot be blank";
                tbx = 0;
            }
            else if (string.IsNullOrEmpty(PreopretyNumTxt.Text))
            {
                valid = false;
                emsg = "Proeprty number cannot be blank";
                tbx = 1;
            }
            else if (string.IsNullOrEmpty(addressTxt.Text))
            {
                valid = false;
                emsg = "Address cannot be blank";
                tbx = 2;
            }
            else if (string.IsNullOrEmpty(numRoomTxt.Text))
            {
                valid = false;
                emsg = "Number of rooms cannot be blank";
                tbx = 3;
            }
            else if (string.IsNullOrEmpty(numBathsTxt.Text))
            {
                valid = false;
                emsg = "Number of baths cannot be blank";
                tbx = 4;
            }
            else if (string.IsNullOrEmpty(Price.Text))
            {
                valid = false;
                emsg = "Price cannot be blank";
                tbx = 5;
            }
            else if (string.IsNullOrEmpty(RentTxt.Text))
            {
                valid = false;
                emsg = "Rent cannot be blank";
                tbx = 6;
            }
            // check coombobox >= 1
            if (OccupiedCB.SelectedIndex < 0)
            {
                valid = false;
                emsg = "You must verify if property is occupied";
                tbx = 7;
            }
            else if (RentalCB.SelectedIndex < 0)
            {
                valid = false;
                emsg = "You must verify if property is a rental";
                tbx = 8;
            }
            else if (FencedCB.SelectedIndex < 0)
            {
                valid = false;
                emsg = "You must select fencing type";
                tbx = 9;
            }
            else if (ParkingCB.SelectedIndex < 0)
            {
                valid = false;
                emsg = "You must select a parking type";
                tbx = 10;
            }
            else if (HeatingCB.SelectedIndex < 0)
            {
                valid = false;
                emsg = "You must select a heating type";
                tbx = 11;
            }
            else if (CoolingCB.SelectedIndex < 0)
            {
                valid = false;
                emsg = "You must select a cooling type";
                tbx = 12;
            }
            return (valid, emsg);
        }
        private (bool, string) CheckDelete(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(PropertyIdTxt.Text))
            {
                valid = false;
                emsg = "You must have property id to delete";
                tbx = 0;
            }

            return (valid, emsg);
        }
        private void SetFormInfo()
        {
            Image img;
            // set texboxs to value of property
            PropertyIdTxt.Text = SelectedProperty.Property_Id.ToString();
            PreopretyNumTxt.Text = SelectedProperty.Property_Number.ToString();
            addressTxt.Text = SelectedProperty.Address;
            numRoomTxt.Text = SelectedProperty.Number_Rooms.ToString();
            numBathsTxt.Text = SelectedProperty.Number_Baths.ToString();
            Price.Text = SelectedProperty.Price.ToString();
            RentTxt.Text = SelectedProperty.Rent.ToString();

            // use find string method of CBX to find the index of the value of selected property
            OccupiedCB.SelectedIndex = OccupiedCB.FindString(SelectedProperty.Occupied);
            RentalCB.SelectedIndex = RentalCB.FindString(SelectedProperty.Rental);
            FencedCB.SelectedIndex = FencedCB.FindString(SelectedProperty.Fenced);
            ParkingCB.SelectedIndex = ParkingCB.FindString(SelectedProperty.Parking);
            HeatingCB.SelectedIndex = HeatingCB.FindString(SelectedProperty.Heating);
            CoolingCB.SelectedIndex = CoolingCB.FindString(SelectedProperty.Cooling);

            // convert binary data in DB to image then set picbox
            img = ConvertBinaryToImage(SelectedProperty.House_Image);
            HousePbx.Image = img;

            // Getwork from DB for this property
            GetWork();
        }
        private void SetProperty()
        {
            try
            {
                SelectedProperty.Property_Id = Convert.ToInt32(PropertyIdTxt.Text);
                SelectedProperty.Property_Number = Convert.ToInt32(PreopretyNumTxt.Text);
                SelectedProperty.Address = addressTxt.Text;
                SelectedProperty.Number_Rooms = Convert.ToInt32(numRoomTxt.Text);
                SelectedProperty.Number_Baths = Convert.ToInt32(numBathsTxt.Text);
                SelectedProperty.Price = Convert.ToInt32(Price.Text);
                SelectedProperty.Rent = Convert.ToInt32(RentTxt.Text);
                SelectedProperty.Occupied = OccupiedCB.SelectedText;
                SelectedProperty.Rental = RentalCB.SelectedText;
                SelectedProperty.Fenced = FencedCB.SelectedText;
                SelectedProperty.Heating = HeatingCB.SelectedText;
                SelectedProperty.Cooling = CoolingCB.SelectedText;

                if (SelectedImg)
                    SelectedProperty.House_Image = BinaryImg;
                else
                    SelectedProperty.House_Image = OrginalProperty.House_Image;
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void GetWork()
        {
            try
            {
                PropertyWork = WorkNeededDB.GetPropertyWork(SelectedProperty.Property_Id);
                SetWork(PropertyWork);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void SetWork(List<WorkNeeded> works)
        {
            string workInfo;

            for (int elmt = 0; elmt <= works.Count; elmt++)
            {
                workInfo = $"{elmt})\n" +
                    $"Property Id: {works[elmt].Property_Id}\n" +
                    $"Work Description: {works[elmt].Work_Needed}\n" +
                    $"Priority Level: {works[elmt].Priority_Level}\n";

                WorkTxt.Text += workInfo;
            }

        }
        private Image ConvertBinaryToImage(byte[] binaryImg)
        {
            try
            {
                byte[] buffer = binaryImg.ToArray();
                MemoryStream mStream = new MemoryStream();
                mStream.Write(buffer, 0, buffer.Length);

                return Image.FromStream(mStream);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void DisplayError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void DisplaySuccess(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PropertiesCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // reset variables & form for next property
            ResetForm();
            SelectedImg = false;
            try
            {
                SelectedProperty = new Property();
                SelectedProperty = PropertyDB.GetProperty(Convert.ToInt32(PropertiesCB.SelectedValue));
                SetFormInfo();
            }
            catch (Exception ex)
            { DisplayError(ex.Message, title); }
        }
        private void ResetForm()
        {
            PropertyIdTxt.Text = string.Empty;
            PreopretyNumTxt.Text = string.Empty;
            addressTxt.Text = string.Empty;
            numRoomTxt.Text = string.Empty;
            numBathsTxt.Text = string.Empty;
            Price.Text = string.Empty;
            RentTxt.Text = string.Empty;
            OccupiedCB.SelectedIndex = -1;
            RentalCB.SelectedIndex = -1;
            FencedCB.SelectedIndex = -1;
            ParkingCB.SelectedIndex = -1;
            HeatingCB.SelectedIndex = -1;
            CoolingCB.SelectedIndex = -1;
            HousePbx.Image = ImgDefault;
        }
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            bool GoodDelete;
            IsValid = CheckDelete(ref Tbx);

            if (IsValid.Item1)
            {
                try
                {
                    GoodDelete = PropertyDB.DeleteProperty(SelectedProperty);

                    if (GoodDelete)
                        DisplaySuccess("Property has been deleted", title);
                    else if (!GoodDelete)
                        DisplayError("Error, property was not deleted", title);

                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }
        private void ResetErrorPv()
        {
            errorPv.Clear();
        }
        private void SetErrorPv(string msg, int tbx)
        {
            switch (tbx)
            {
                case 0:
                    errorPv.SetError(PropertyIdTxt, msg);
                    break;
                case 1:
                    errorPv.SetError(PreopretyNumTxt, msg);
                    break;
                case 2:
                    errorPv.SetError(addressTxt, msg);
                    break;
                case 3:
                    errorPv.SetError(numRoomTxt, msg);
                    break;
                case 4:
                    errorPv.SetError(numBathsTxt, msg);
                    break;
                case 5:
                    errorPv.SetError(Price, msg);
                    break;
                case 6:
                    errorPv.SetError(RentTxt, msg);
                    break;
                case 7:
                    errorPv.SetError(OccupiedCB, msg);
                    break;
                case 8:
                    errorPv.SetError(RentalCB, msg);
                    break;
                case 9:
                    errorPv.SetError(FencedCB, msg);
                    break;
                case 10:
                    errorPv.SetError(ParkingCB, msg);
                    break;
                case 11:
                    errorPv.SetError(HeatingCB, msg);
                    break;
                case 12:
                    errorPv.SetError(CoolingCB, msg);
                    break;
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            bool GoodUpdate;
            int Tbx = -1;
            IsValid = CheckEdit(ref Tbx);

            if (IsValid.Item1)
            {
                try
                {
                    SetProperty();
                    GoodUpdate = PropertyDB.UpdateProperty(SelectedProperty);

                    if (GoodUpdate)
                        DisplaySuccess("Property was edited", title);
                    else if (!GoodUpdate)
                        DisplayError("Error, property was not edited", title);
                }
                catch (Exception ex)
                { throw ex; }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void HousePbx_Click(object sender, EventArgs e)
        {
            // if person double clicks imagee can select a different house image
            var ImgPath = string.Empty;
            SelectedImg = true;

            using (OpenFileDialog OpenFileDialog = new OpenFileDialog())
            {
                // set up open dialog for images
                OpenFileDialog.InitialDirectory = "C:\\";
                OpenFileDialog.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|" +
                    "*.tif|Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
                OpenFileDialog.FilterIndex = 5;
                OpenFileDialog.RestoreDirectory = true;
                // if ok is clicked then convert image to bitmap
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImgPath = OpenFileDialog.FileName;
                    FileStream fStream = new FileStream(ImgPath, FileMode.Open, FileAccess.Read);
                    //this is orginal commented out below
                    //byte[] buffer = new byte[fStream.Length];
                    //fStream.Read(buffer, 0, (int)fStream.Length);
                    BinaryImg = new byte[fStream.Length];
                    fStream.Read(BinaryImg, 0, (int)fStream.Length);
                    fStream.Close();
                    // original commented out below
                    //StringBytes = Convert.ToBase64String(buffer);

                }
                // eventualy might need to do something if dialogResult is not OK
            }
        }
        private void WorkTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PropertyWork.Count > 0)
            {
                EditPropertyWorkForm PropertyWF = new EditPropertyWorkForm();
                PropertyWF.ShowDialog();
            }
            else
                DisplayError("There is currently no work for this property", title);
            
        }
    }
}
