using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{ 
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MainTenanceTime = "Sistem Bakımda.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string UnitPriceInvalid = "Ürün Fiyatı Hatalı";
        public static string ProductCountOfCategoryError = "Kategorideki limit sayısını aştınız.";
        public static string ProductNameoAlreadyExists = "Aynı kategoride, aynı ada sahip birden fazla ürün bulunamaz!";
        public static string CategoryLimitedExceded = "Katergori limiti aşıldı. Daha Fazla ürün eklenemez!!!";
        public static string AuthorizationDenied = "Yetkiniz Yok.";
        public static string UserRegistered = "Kayıt Başarılı.";
        public static string UserNotFound = "Kullanıcı blunamadı!";
        public static string PasswordError = "Hatalı Şifre.";
        public static string SuccessfulLogin = "Başarılı Giriş.";
        public static string UserAlreadyExists = "Kullanıcı Mevcut.";
        public static string AccessTokenCreated = "Erişim Jetonu Oluşturuldu.";
    }
}