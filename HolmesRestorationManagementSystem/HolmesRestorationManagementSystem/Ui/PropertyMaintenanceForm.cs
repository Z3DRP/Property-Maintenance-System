using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using HolmesRestorationManagementSystem.Business_Objects;
using HolmesRestorationManagementSystem.Data_Access_Layer;

namespace HolmesRestorationManagementSystem.Ui
{
    public partial class PropertyMaintenanceForm : Form
    {
        List<TruthValues> Truths1 = new List<TruthValues>();
        List<TruthValues> Truths2 = new List<TruthValues>();
        List<Fencing> AllFencing = new List<Fencing>();
        List<Parking> AllParking = new List<Parking>();
        List<Heating> AllHeating = new List<Heating>();
        List<Cooling> AllCooling = new List<Cooling>();
        List<Property> Properties = new List<Property>();

        string title = "Holmes Management System";
        string OldCellValue = null;
        int ColumnIdx;
        int RowIdx;
        int CellsChanged = 0;
        bool CellChanged = false;
        (bool, string) IsValid;
        bool SelectedImage = false;
        Property currentProperty;
        Property SelectedProperty = new Property();
        byte[] BinaryImg;


        public PropertyMaintenanceForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            bool GoodAdd;
            IsValid = CheckForm(ref Tbx);

            if (IsValid.Item1)
            {
                try
                {
                    currentProperty = new Property();
                    SetProperty(false);
                    GoodAdd = PropertyDB.AddProperty(currentProperty);
                    if (GoodAdd)
                        DisplaySuccess("Property has been added", title);
                    else
                        DisplayError("Error, property was not added", title);

                    ClearForm();

                }
                catch (Exception ex)
                { throw ex; }

            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        { 
            try
            {
                Properties = PropertyDB.GetProperties();
                // depending on how it looks have seperate form for browse and search shown on browse
                //PropertyBrowseForm PropertyBF = new PropertyBrowseForm(Properties);
                PropertyDG.DataSource = Properties;

                if (Properties.Count == 0)
                    DisplaySuccess("There are currently no properties", title);
            }
            catch(Exception ex)
            { DisplayError(ex.Message, title); }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string sType = string.Empty;
            int Tbx = -1;
            IsValid = CheckSearch(ref sType, ref Tbx);

            if (IsValid.Item1)
            {
                try
                {
                    currentProperty = new Property();
                    switch (sType)
                    {
                        case "id":
                            currentProperty = PropertyDB.GetProperty(Convert.ToInt32(IdTxt.Text));
                            Properties.Add(currentProperty);
                            break;
                        case "add":
                            Properties = PropertyDB.SearchProperties(AddressTxt.Text.Trim());
                            break;
                    }

                    if (Properties.Count >= 1)
                        PropertyDG.DataSource = Properties;                   
                    else
                    {
                        DisplayError("Match not found", title);
                        Properties = PropertyDB.GetProperties();
                        PropertyDG.DataSource = Properties;
                    }

                    ClearForm();
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            IsValid = CheckForm(ref Tbx);
            bool GoodUpdate;           

            if (IsValid.Item1)
            {
                try
                {
                    currentProperty = new Property();
                    SetProperty(true);
                    GoodUpdate = PropertyDB.UpdateProperty(currentProperty);

                    if (GoodUpdate)
                        DisplaySuccess("Property has been updated", title);
                    else
                        DisplayError("Errpr, property was not updated", title);

                    ClearForm();
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            IsValid = CheckDelete(ref Tbx);
            bool GoodDel;

            if (IsValid.Item1)
            {
                try
                {
                    currentProperty = new Property();
                    currentProperty.Property_Id = Convert.ToInt32(IdTxt.Text);
                    GoodDel = PropertyDB.DeleteProperty(currentProperty);

                    if (GoodDel)
                        DisplaySuccess("Property has been deleted", title);
                    else
                        DisplayError("Error, proeprty was not deleted", title);

                    ClearForm();
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
            PropertyDG.DataSource = null;
        }
        private void ClearForm()
        {
            IdTxt.Text = string.Empty;
            PropertyNumTxt.Text = string.Empty;
            AddressTxt.Text = string.Empty;
            NumRoomTxt.Text = string.Empty;
            NumBathsTxt.Text = string.Empty;
            PriceTxt.Text = string.Empty;
            RentTxt.Text = string.Empty;
            OccupiedCbx.SelectedIndex = -1;
            RentalCbx.SelectedIndex = -1;
            FencedCbx.SelectedIndex = -1;
            ParkingCbx.SelectedIndex = -1;
            HeatingCbx.SelectedIndex = -1;
            CoolingCbx.SelectedIndex = -1;
        }
        private void PropertyMaintenanceForm_Load(object sender, EventArgs e)
        {
            Truths1 = TruthValuesDB.GetTruthValues();
            Truths2 = TruthValuesDB.GetTruthValues();
            AllFencing = FenceDB.GetFencingInfo();
            AllParking = ParkingDB.GetParking();
            AllHeating = HeatingDB.GetHeatingInfo();
            AllCooling = CoolingDB.GetCoolingInfo();

            RentalCbx.DataSource = Truths1;
            RentalCbx.DisplayMember = "Truth_Value";
            RentalCbx.ValueMember = "Id";

            OccupiedCbx.DataSource = Truths2;
            OccupiedCbx.DisplayMember = "Truth_Value";
            OccupiedCbx.ValueMember = "Id";

            FencedCbx.DataSource = AllFencing;
            FencedCbx.DisplayMember = "Fence_Type";
            FencedCbx.ValueMember = "Id";

            ParkingCbx.DataSource = AllParking;
            ParkingCbx.DisplayMember = "Parking_Type";
            ParkingCbx.ValueMember = "Id";

            HeatingCbx.DataSource = AllHeating;
            HeatingCbx.DisplayMember = "Heating_Type";
            HeatingCbx.ValueMember = "Id";

            CoolingCbx.DataSource = AllCooling;
            CoolingCbx.DisplayMember = "Cooling_Type";
            CoolingCbx.ValueMember = "Id";
        }
        private void SetProperty(bool isUpdate)
        {
            int nextId;
            try
            {
                if (!isUpdate)
                {
                    nextId = PropertyDB.GetNextPropertyId();
                    currentProperty.Property_Id = nextId;
                }
                if (isUpdate)
                    currentProperty.Property_Id = Convert.ToInt32(IdTxt.Text);

                currentProperty.Property_Number = Convert.ToInt32(PropertyNumTxt.Text);
                currentProperty.Address = AddressTxt.Text.Trim();
                currentProperty.Number_Rooms = Convert.ToInt32(NumRoomTxt.Text);
                currentProperty.Number_Baths = Convert.ToInt32(NumBathsTxt.Text);
                // cbx set might have to change might have to get selectedValue
                // then query db for value of id selected
                currentProperty.Occupied = Convert.ToString(OccupiedCbx.SelectedItem);
                currentProperty.Rental = RentalCbx.SelectedText;
                currentProperty.Fenced = FencedCbx.SelectedText;
                currentProperty.Heating = Convert.ToString(HeatingCbx.SelectedItem);
                currentProperty.Cooling = CoolingCbx.SelectedText;
                // set image
                if (SelectedImage)
                    currentProperty.House_Image = BinaryImg;
            }
            catch(Exception ex)
            { throw ex; }
        }
        
        private void SetErrorPv(string msg, int tbx)
        {
            switch(tbx)
            {
                case 0:
                    errorPv.SetError(IdTxt,msg);
                    break;
                case 1:
                    errorPv.SetError(PropertyNumTxt, msg);
                    break;
                case 2:
                    errorPv.SetError(AddressTxt, msg);
                    break;
                case 3:
                    errorPv.SetError(NumRoomTxt, msg);
                    break;
                case 4:
                    errorPv.SetError(NumBathsTxt, msg);
                    break;
                case 5:
                    errorPv.SetError(PriceTxt, msg);
                    break;
                case 6:
                    errorPv.SetError(RentTxt, msg);
                    break;
                case 7:
                    errorPv.SetError(OccupiedCbx, msg);
                    break;
                case 8:
                    errorPv.SetError(RentalCbx, msg);
                    break;
                case 9:
                    errorPv.SetError(FencedCbx, msg);
                    break;
                case 10:
                    errorPv.SetError(ParkingCbx, msg);
                    break;
                case 11:
                    errorPv.SetError(HeatingCbx, msg);
                    break;
                case 12:
                    errorPv.SetError(CoolingCbx, msg);
                    break;
            }
        }
        private void ResetErrorPv()
        {
            errorPv.Clear();
        }

        private void FileSelectBtn_Click(object sender, EventArgs e)
        {
            var ImgPath = string.Empty;
            SelectedImage = true;

            using(OpenFileDialog OpenFileDialog = new OpenFileDialog())
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
        private void DisplaySuccess(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private (bool, string) CheckForm(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(IdTxt.Text))
            {
                valid = false;
                emsg = "Id cannot be blank";
                tbx = 0;
            }
            else if (string.IsNullOrEmpty(PropertyNumTxt.Text))
            {
                valid = false;
                emsg = "Property number cannot be false";
                tbx = 1;
            }
            else if (string.IsNullOrEmpty(AddressTxt.Text))
            {
                valid = false;
                emsg = "Address cannot be blank";
                tbx = 2;
            }
            else if (string.IsNullOrEmpty(NumRoomTxt.Text))
            {
                valid = false;
                emsg = "Number of rooms cannot be blank";
                tbx = 3;
            }
            else if (string.IsNullOrEmpty(NumBathsTxt.Text))
            {
                valid = false;
                emsg = "Number of baths cannot be blank";
                tbx = 4;
            }
            else if (string.IsNullOrEmpty(PriceTxt.Text))
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
            if (!int.TryParse(IdTxt.Text, out int id))
            {
                valid = false;
                emsg = "Id must be numeric";
                tbx = 0;
            }
            else if (!int.TryParse(PropertyNumTxt.Text, out int propId))
            {
                valid = false;
                emsg = "Property Id must be numeric";
                tbx = 1;
            }
            else if (!int.TryParse(NumRoomTxt.Text, out int numRoom))
            {
                valid = false;
                emsg = "Number of rooms must be numeric";
                tbx = 3;
            }
            else if (!int.TryParse(NumBathsTxt.Text, out int numBath))
            {
                valid = false;
                emsg = "Number of baths must be numeric";
                tbx = 4;
            }
            else if (!int.TryParse(PriceTxt.Text, out int price))
            {
                valid = false;
                emsg = "Price must be numeric";
                tbx = 5;
            }
            else if (!int.TryParse(RentTxt.Text, out int rent))
            {
                valid = false;
                emsg = "Rent must be numeric";
                tbx = 6;
            }
            // double check to make sure that this catches if CBXs
            // does not get changed
            if (OccupiedCbx.SelectedIndex == -1)
            {
                valid = false;
                emsg = "Must specify if property is occupied";
                tbx = 7;
            }
            else if (RentalCbx.SelectedIndex == -1)
            {
                valid = false;
                emsg = "Must specify if property is a rental";
                tbx = 8;
            }
            else if (FencedCbx.SelectedIndex == -1)
            {
                valid = false;
                emsg = "Must select a fence type";
                tbx = 9;
            }
            else if (ParkingCbx.SelectedIndex == -1)
            {
                valid = false;
                emsg = "Must select parking type";
                tbx = 10;
            }
            else if (HeatingCbx.SelectedIndex == -1)
            {
                valid = false;
                emsg = "Must select heating type";
                tbx = 11;
            }
            else if (CoolingCbx.SelectedIndex == -1)
            {
                valid = false;
                emsg = "Must select cooling type";
                tbx = 12;
            }

            return (valid, emsg);
        }
        private (bool, string) CheckDelete(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;
            tbx = 0;

            if (string.IsNullOrEmpty(IdTxt.Text))
            {
                valid = false;
                emsg = "You must enter Property Id to delete";
            }
            else if (!int.TryParse(IdTxt.Text, out int id))
            {
                valid = false;
                emsg = "Proeprty Id must be numeric";
            }

            return (valid, emsg);
        }
        private (bool,string) CheckSearch(ref string searchType, ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(IdTxt.Text) && string.IsNullOrEmpty(AddressTxt.Text))
            {
                valid = false;
                emsg = "You must enter an Id or Address to search";
                tbx = 0;
            }
            if (!string.IsNullOrEmpty(IdTxt.Text))
            {
                if (!int.TryParse(IdTxt.Text, out int id))
                {
                    valid = false;
                    emsg = "Id must be numeric";
                    tbx = 2;
                }
            }
            if (!string.IsNullOrEmpty(IdTxt.Text) && string.IsNullOrEmpty(AddressTxt.Text))
            {
                if (int.TryParse(IdTxt.Text, out int id))
                    searchType = "id";
            }
            else if (string.IsNullOrEmpty(IdTxt.Text) && !string.IsNullOrEmpty(AddressTxt.Text))
            {
                searchType = "add";
            }

            return (valid, emsg);
        }


        private void PropertyDG_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CellsChanged >= 1)
            {
                try
                {
                    bool GoodEdit = PropertyDB.UpdateProperty(SelectedProperty);

                    if (GoodEdit)
                        DisplaySuccess("Property Has been edited", title);
                    else if (!GoodEdit)
                        DisplayError("Property edit failed", title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
        }

        private void PropertyDG_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            // might have to change to if CellssChanged >= 1 like tenant maintenance form
            if (CellChanged)
            {
                try
                {
                    switch (ColumnIdx)
                    {
                        case 0:
                            SelectedProperty.Property_Id = Convert.ToInt32(OldCellValue);
                            DisplayError("Property Id cannot be edited", title);
                            break;
                        case 1:
                            SelectedProperty.Property_Number =
                                Convert.ToInt32(PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value);
                            break;
                        case 2:
                            SelectedProperty.Address = PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 3:
                            SelectedProperty.Number_Rooms =
                                Convert.ToInt32(PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value);
                            break;
                        case 4:
                            SelectedProperty.Number_Baths =
                                Convert.ToInt32(PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value);
                            break;
                        case 5:
                            SelectedProperty.Price =
                                Convert.ToInt32(PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value);
                            break;
                        case 6:
                            SelectedProperty.Rent =
                                Convert.ToInt32(PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value);
                            break;
                        case 7:
                            SelectedProperty.Occupied = PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 8:
                            SelectedProperty.Rental = PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 9:
                            SelectedProperty.Fenced = PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 10:
                            SelectedProperty.Parking = PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 11:
                            SelectedProperty.Heating = PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 12:
                            SelectedProperty.Cooling = PropertyDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                    }
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            CellChanged = false;
        }

        private void PropertyDG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CellsChanged++;
            CellChanged = true;
        }

        private void PropertyDG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PropertyDG.CurrentCell.ColumnIndex >= 1)
            {
                PropertyDG.EditMode = DataGridViewEditMode.EditProgrammatically;
                PropertyDG.BeginEdit(true);
            }
            else
                PropertyDG.ReadOnly = true;
        }

        private void PropertyDG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            OldCellValue = PropertyDG.CurrentCell.Value.ToString();
            ColumnIdx = PropertyDG.CurrentCell.ColumnIndex;
            RowIdx = PropertyDG.CurrentCell.RowIndex;
        }
    }
}
