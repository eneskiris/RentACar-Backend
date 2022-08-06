using System;
using System.Runtime.Serialization;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarInvalid = "Araba eklenemedi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarsListed = "Arabalar listelendi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandInvalid = "Marka eklenemedi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandsListed = "Markalar listelendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorInvalid = "Renk eklenemedi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorsListed = "Renkler listelendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserInvalid = "Kullanıcı eklenemedi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string UserRegistered = "UserRegistered";
        public static string UserNotFound = "UserNotFound";
        public static string PasswordError = "PasswordError";
        public static string SuccesfullLogin = "SuccesfullLogin";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerInvalid = "Müşteri eklenemedi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerListed = "Müşteriler listelendi.";

        public static string RentalAdded = "Kiralama başarılı.";
        public static string RentalInvalid = "Kiralama başarısız.";
        public static string RentalUpdated = "Kiralama güncellendi.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string RentalListed = "Kiralamalar listelendi.";

        public static string CarImageAdded = "Fotoğraf eklendi.";
        public static string CarImageDeleted = "Fotoğraf silindi.";
        public static string ImagesListed = "Fotoğraflar listelendi.";
        public static string CarImageUpdated = "Fotoğraf güncellendi.";

        public static string AuthorizationDenied = "AuthorizationDenied!";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string AccessTokenCreated = "AccessTokenCreated";
    }
}

