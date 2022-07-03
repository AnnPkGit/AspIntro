using Intro.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intro.DAL.Context
{
    public class UsersConfiguration : IEntityTypeConfiguration<Entities.User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Начальная конфигурация при построении модели 
            // делегируется из контекста. Здесь 
            // можно задать начальное значение полей, 
            // поменять имя таблиц (по умолчанию - имя класса)
            // а также задать начальные данные для таблицы (seed)

            builder.HasData(new User
            {
                Id        = System.Guid.NewGuid(),
                RealName  = "Корневой администратор",
                Login     = "Admin",
                PassHash  = "",
                Email     = "",
                PassSalt  = "",
                RegMoment = System.DateTime.Now,
                Avatar    = ""
            });
        }
    }
}
