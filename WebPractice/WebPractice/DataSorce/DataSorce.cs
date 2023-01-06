using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Text;
using WebPractice.Models;

namespace WebPractice.DataSorce
{
    public class DataSorce
    {
        public static Models.TastModel.TastText Index()
        {
            // 接続文字列
            var connectionString =
                "Server=localhost;Port=3306;Userid=root;Password=15357595a;Database=mysql";

            // 実行するSQL
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM noodle ");

            // 接続・SQL実行に必要なインスタンスを生成
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand(sql.ToString(), connection))
            {
                // 接続開始
                connection.Open();
                var tasts = new Models.TastModel.TastText();
                command.CommandText = sql.ToString();
                
                // SQLの実行
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tasts = new Models.TastModel.TastText()
                        {
                            Name = reader["Name"].ToString(),
                            Tast = reader["Tast"].ToString(),
                            Note = reader["Note"].ToString(),
                            Score = int.Parse(reader["Score"].ToString()!)
                        };
                    }
                }
                return tasts;
            }
        }
    }
}
