using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductCountOfCategoryError = "10 dan fazla ürün eklenemez";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldıgından eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string AccessTokenCreated;
        internal static string UserAlreadyExists;
        internal static string SuccessfulLogin;
        internal static User PasswordError;
        internal static User UserNotFound;
        internal static string UserRegistered;
    }
}
