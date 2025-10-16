using System.Reflection;

namespace NET_CarRentalSystem.Shared.Utilities;

public static class EnumHelper
{
    /// <summary>
    /// Chuyển đổi một Enum thành một danh sách các đối tượng model tùy chỉnh.
    /// Model bắt buộc phải có đúng 2 thuộc tính: một int và một string.
    /// </summary>
    /// <typeparam name="TModel">Kiểu của đối tượng model để map dữ liệu vào.</typeparam>
    /// <param name="enumType">Kiểu của Enum cần chuyển đổi (sử dụng typeof()).</param>
    /// <returns>Một danh sách các đối tượng model chứa Id và Name của Enum.</returns>
    /// <exception cref="ArgumentException">Ném ra nếu kiểu truyền vào không phải là Enum hoặc model không hợp lệ.</exception>
    public static List<TModel> GetEnumAsModelList<TModel>(Type enumType) where TModel : new()
    {
        if (!enumType.IsEnum)
        {
            throw new ArgumentException($"{enumType.Name} không phải là một Enum.");
        }

        var properties = typeof(TModel).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        if (properties.Length != 2)
        {
            throw new ArgumentException($"Model '{typeof(TModel).Name}' phải có chính xác 2 thuộc tính (một int, một string).");
        }

        var intProperty = properties.FirstOrDefault(p => p.PropertyType == typeof(int));
        var stringProperty = properties.FirstOrDefault(p => p.PropertyType == typeof(string));

        if (intProperty == null || stringProperty == null)
        {
            throw new ArgumentException($"Model '{typeof(TModel).Name}' phải có một thuộc tính kiểu 'int' và một thuộc tính kiểu 'string'.");
        }

        var result = new List<TModel>();
        var enumValues = Enum.GetValues(enumType);

        foreach (var enumValue in enumValues)
        {
            var modelInstance = new TModel();

            stringProperty.SetValue(modelInstance, enumValue.ToString());
            intProperty.SetValue(modelInstance, Convert.ToInt32(enumValue));

            result.Add(modelInstance);
        }

        return result;
    }

    /// <summary>
    /// Overload cho phép truyền vào kiểu generic của Enum thay vì Type.
    /// </summary>
    public static List<TModel> GetEnumAsModelList<TEnum, TModel>()
        where TEnum : Enum
        where TModel : new()
    {
        return GetEnumAsModelList<TModel>(typeof(TEnum));
    }
}