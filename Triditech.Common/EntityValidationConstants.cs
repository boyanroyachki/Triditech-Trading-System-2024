namespace Triditech.Common
{
    /// <summary>
    /// Static class that holds more static classes, named after the application entities. 
	/// The properties are constant values that are used to validate the entity properties.
    /// </summary>
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int MaxNameLength = 50;
            public const int MinNameLength = 3;
        }

        public static class Product
        {
            public const int MaxNameLength = 50;
            public const int MinNameLength = 3;

            public const int MaxDescriptionLength = 1500;
            public const int MinDescriptionLength = 3;

            public const int MaxIndustryLength = 150;
            public const int MinIndustryLength = 3;

            public const int MaxMaterialLength = 150;
            public const int MinMaterialLength = 3;

            public const int MaxProcessNameLength = 150;
            public const int MinProcessNameLength = 3;

            public const int MaxWeightLength = 50;
            public const int MinWeightLength = 2;
        }

        public static class Vendor
        {
            public const int MaxVendorsPhoneLength = 16;
            public const int MinVendorsPhoneLength = 10;
        }
        public static class ProductImage
        {

        }
    }
}
