using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Api.Utils
{
    public static class ContextUtil
    {
        public static void RemovePluralization(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entity in builder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }
        }
        public static void SetDecimalPrecision(this ModelBuilder builder, int longitud = 16, int escala = 2)
        {
            foreach (var entity in builder.Model.GetEntityTypes()
                                                               .SelectMany(t => t.GetProperties())
                                                               .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                entity.SetColumnType($"decimal({longitud},{escala})");
            }
        }
    }
}
