using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi gecersiz";
        internal static string MaintenanceTime = "sistem bakımda";
        internal static string ProductListed = "ürünler listelendi";
        internal static string ProductsListed;
        internal static object UnitPriceInvalid;
        public static object ProductCountOfCategoryError="bbir kategoride en fazla 10 ürün olabilir";
        public static object ProductNameAlreadyExist="bu isimde zaten başka bir ürün var";
        public static object ProductCategoryLimitExceded="limit aşıldı";
        public static string  AuthorizationDenied="yetkiniz yok";
    }
}
