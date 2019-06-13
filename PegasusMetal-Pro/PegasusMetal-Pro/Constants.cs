using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusMetal_Pro
{
    public class Info
    {
        static Info info;
        public Staff staff;
        public ProjectContinuing projectContinuing;
        private Info()
        {

        }

        public static Info GetInstance()
        {
            if (info == null)
            {
                info = new Info();
            }
            return info;
        }
    }
    public static class Constants
    {
        public const string SPLITTER = "%&(SPLIT)";
        public const int PORT = 5661;
        public const string IP_ADDRESS = "185.207.38.178";
        public static class BarButtonNames
        {
            public const string BAR_BUTTON_ITEM_ROLES = "barButtonItemRoller";
            public const string BAR_BUTTON_ITEM_GENERAL_STATUS_CONTROL = "barButtonItemGenelDurumKontrol";
            public const string BAR_BUTTON_ITEM_PROJECT_CONTINUING = "barButtonItemDevamEden";
            public const string BAR_BUTTON_ITEM_NEW_PROJECTS = "barButtonItemYeniProjeler";
            public const string BAR_BUTTON_ITEM_CREATE_OFFER = "barButtonItemTeklifOlustur";
            public const string BAR_BUTTON_ITEM_ORDER_CONFIRMATION = "barButtonItemSiparisOnayı";
            public const string BAR_BUTTON_ITEM_ARCHIVE = "barButtonItemArsiv";
            public const string BAR_BUTTON_ITEM_STOCK = "barButtonItemStok";
            public const string BAR_BUTTON_ITEM_STAFF = "barButtonItemPersonel";
            public const string BAR_BUTTON_ITEM_COMPANIES = "barButtonItemFirmalar";
            public const string BAR_BUTTON_ITEM_PROCESS_PRICES = "barButtonItemIslemUcretleri";
            public const string BAR_BUTTON_ITEM_MATERIAL_PRICES = "barButtonItemMalzemeUcretleri";
            public const string BAR_BUTTON_ITEM_INOUTPUT = "barButtonItemHareketler";
            public const string BAR_BUTTON_ITEM_EXPENSES = "barButtonItemGiderler";
            public const string BAR_BUTTON_ITEM_PIECE_CODES = "barButtonItemParcaKodları";
        }
        //public static DataTable ToDataTable<T>(this IList<T> data)
        //{
        //    PropertyDescriptorCollection props =
        //    TypeDescriptor.GetProperties(typeof(T));
        //    DataTable table = new DataTable();
        //    for (int i = 0; i < props.Count; i++)
        //    {
        //        PropertyDescriptor prop = props[i];
        //        table.Columns.Add(prop.Name, prop.PropertyType);
        //    }
        //    object[] values = new object[props.Count];
        //    foreach (T item in data)
        //    {
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            values[i] = props[i].GetValue(item);
        //        }
        //        table.Rows.Add(values);
        //    }
        //    return table;
        //}
    }
    public static class Lists
    {
        public static ObservableCollection<Staff> staffs = new ObservableCollection<Staff>();
        public static ObservableCollection<User> users = new ObservableCollection<User>();
        public static ObservableCollection<Company> companies = new ObservableCollection<Company>();
        public static ObservableCollection<ProjectContinuing> projectContinuings = new ObservableCollection<ProjectContinuing>();
        public static ObservableCollection<Project> projects = new ObservableCollection<Project>();
        public static ObservableCollection<Stock> stocks = new ObservableCollection<Stock>();
        public static ObservableCollection<StockCategory> stockCategories = new ObservableCollection<StockCategory>();
        public static ObservableCollection<Roles> roles = new ObservableCollection<Roles>();
        public static ObservableCollection<UserRole> userRoles = new ObservableCollection<UserRole>();
        public static ObservableCollection<Material> materials = new ObservableCollection<Material>();
        public static ObservableCollection<Piece> pieces = new ObservableCollection<Piece>();
        public static ObservableCollection<Process> processes = new ObservableCollection<Process>();
    }
    public static class OPCodes
    {
        public const string LOGIN = "Login";
        public const string LOGIN_SUCCESS = "LoginSuccess";
        public const string LOGIN_FAIL = "LoginFail";
        public const string END_OF_LOGIN = "EndLogin";
        public const string ACCEPTED_OFFER = "AcceptedOffer";
        public const string COMPANY = "Company";
        public const string INOUTPUT = "InOutput";
        public const string MATERIAL = "Material";
        public const string OFFER = "Offer";
        public const string PIECE = "Piece";
        public const string PROCESS = "Process";
        public const string PROJECT = "Project";
        public const string PROJECT_CONTINUING = "ProjectContinuing";
        public const string PROJECT_FILES = "ProjectFiles";
        public const string ROLES = "Roles";
        public const string STAFF = "Staff";
        public const string DELETE_STAFF = "DeleteStaff";
        public const string STOCK = "Stock";
        public const string STOCK_CATEGORY = "StockCategory";
        public const string USER = "User";
        public const string USER_ROLE = "UserRole";
        public const string GET_PERSONAL_LIST = "GetPersonalList";
        public const string GET_ROLE_LIST = "GetRoleList";
        public const string GET_USER_ROLE_LIST = "GetUserRoleList";
        public const string GET_USER_LIST = "GetUserList";
        public const string DELETE_USER_ROLE = "DeleteUserRole";
        public const string GET_COMPANIES = "GetCompany";
        public const string GET_STOCK_CATEGORIES = "GetStockCategory";
        public const string GET_STOCKS = "GetStock";
        public const string GET_MATERIALS = "GetMaterial";
        public const string GET_PIECES = "GetPiece";
        public const string GET_PROJECTS = "GetProjects";
        public const string GET_PROCESSES = "GetProcess";
    }
    public class Reason
    {
        public string Explanation { get; set; }
    }
    //public class User
    //{
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //}

    //public class Staff
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //}
}

