using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySqlConnector;

namespace CarRentAPI.Common
{
    public class SqlDataAccess
    {
        //private readonly IConfiguration _config;
        private readonly string _connectionStringName;

        public SqlDataAccess()
        {
            //_connectionStringName = "server=127.0.0.1;user id=TestUser;database=carrent";
            _connectionStringName = "Server=127.0.0.1;Database=carrent;Uid=TestUser;Pwd=geheim";
            //_config = Configration.;
        }

        public List<T> LoadData<T>(string sql)
        {
            using (IDbConnection connection = new MySqlConnection(_connectionStringName))
            {
                IEnumerable<T> data = connection.Query<T>(sql);
                return data.ToList();
            }
        }

        public T LoadDataById<T>(string sql)
        {
            IDbConnection connection = new MySqlConnection(_connectionStringName);
            IEnumerable<T> data = connection.Query<T>(sql);
            return data.First();
        }

        public void SaveData(string sql)
        {
            using (IDbConnection connection = new MySqlConnection(_connectionStringName))
            {
                connection.Execute(sql);
            }
        }


        public void CreateDBShema()
        {
            /***********************************************************/
            /* Folgendes muss auf der DB zuerst gemacht werden:
            /*
             
            Drop database if exists carrent;

            Create Database carrent;

            use carrent;

            Create User 'TestUser'@'%' identified by 'geheim';

            Grant all privileges ON carrent.* to 'TestUser'@'%';

             */


            SaveData("Create Table Customer(CustomerId INT NOT NULL auto_increment, FirstName varchar(25) not null, LastName varchar(25) not null, Street varchar(50) not null, City varchar(50) not null, primary key (CustomerId))");
            SaveData("Create Table CarClass(ClassId varchar(36) not null, Class int not null, PricePerDay decimal(7,2) not null, primary key ( ClassId))");
            SaveData("Create Table CarBrand(BrandId varchar(36) not null, Brand varchar(50) not null, primary key ( BrandId))");
            SaveData("Create Table CarType( TypeId varchar(36) not null, Type varchar(50) not null, BrandId varchar(36) not null, primary key (TypeId), foreign key (BrandId) references CarBrand(BrandId))");
            SaveData("Create Table Car(CarId INT NOT NULL auto_increment, ClassId varchar(36) not null, TypeId varchar(36) not null, primary key (CarId), foreign key (ClassId) references CarClass(ClassId), foreign key (TypeId) references CarType(TypeId))");
            SaveData("Create Table Contract(ContractId INT NOT NULL auto_increment, CustomerId INT not null, CarId INT not null, Status int not null, Days int not null, Total decimal(10,2) not null, primary key ( ContractId), foreign key (CustomerId) references Customer(CustomerId), foreign key (CarId) references Car(CarId))");
            SaveData("Create View CarV AS SELECT c.CarId, cc.ClassId, cc.Class, cc.PricePerDay, ct.TypeId, ct.Type, cb.BrandId, cb.Brand FROM Car c inner join CarClass cc on cc.ClassId=c.ClassId inner join CarType ct on ct.TypeId=c.TypeId inner join CarBrand cb on cb.BrandId=ct.BrandId");
            SaveData("Create View CarVType AS Select ct.TypeId, ct.Type, cb.BrandId, cb.Brand from CarType ct inner join CarBrand cb on cb.BrandId=ct.BrandId");
            SaveData("Create View ContractV AS Select con.ContractId, cus.CustomerId, cus.FirstName, cus.LastName, cus.Street, cus.City, car.CarId, car.ClassId, car.Class, car.PricePerDay, car.TypeId, car.Type, car.BrandId, car.Brand, con.Status, con.Days, con.Total From Contract con inner join Customer cus on cus.CustomerId = con.CustomerId inner join CarV car on car.CarId = con.CarId");
        }

    }
}
