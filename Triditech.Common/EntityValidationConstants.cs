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

        }
    }
}
