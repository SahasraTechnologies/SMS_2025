using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core
{
    public static class DataTableHelper
    {
        public static List<object> GetDataTableColumns<T>()
        {
            return typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(p =>
                {
                    var displayName = GetDisplayName(p);
                    return new
                    {
                        title = displayName ?? p.Name,
                        data = p.Name,
                        visible = !string.IsNullOrWhiteSpace(displayName) // ❗ visible = false if no display name
                    };
                })
                .ToList<object>();
        }

        private static string GetDisplayName(PropertyInfo property)
        {
            var attr = property.GetCustomAttribute<DisplayAttribute>();
            return attr?.Name?.Trim();
        }
    }
}
