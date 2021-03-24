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
        public static string AuthorizationDenied = "AuthorizationDenied";
        public static string AccessTokenCreated = "AccessTokenCreated";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string SuccessfulLogin = "SuccessfulLogin";
        public static string PasswordError = "PasswordError";
        public static string UserNotFound = "UserNotFound";
        public static string UserRegistered = "UserRegistered";
    }
}
