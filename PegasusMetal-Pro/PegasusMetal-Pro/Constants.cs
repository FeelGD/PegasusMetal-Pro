using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusMetal_Pro
{
    public class Info
    {
        static Info info;
        public Staff staff;
        //public ProjectContinuing projectContinuing;
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
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
            TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
    public static class Lists
    {
        public static List<Staff> staffs = new List<Staff>();
        public static List<Company> companies = new List<Company>();
        public static List<ProjectContinuing> projectContinuings = new List<ProjectContinuing>();
        public static List<Project> projects = new List<Project>();
        public static List<Stock> stocks = new List<Stock>();
        public static List<StockCategory> stockCategories = new List<StockCategory>();
    }
    public static class OPCodes
    {
        public const string LOGIN = "Login";
        public const string LOGIN_SUCCESS = "LoginSuccess";
        public const string LOGIN_FAIL = "LoginFail";
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
        public const string STOCK = "Stock";
        public const string STOCK_CATEGORY = "StockCategory";
        public const string USER = "User";
        public const string USER_ROLE = "UserRole";
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

