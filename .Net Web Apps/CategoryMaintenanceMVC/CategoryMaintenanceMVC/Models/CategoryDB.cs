using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CategoryMaintenanceMVC.Models
{
    public static class CategoryDB
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HalloweenConnection"].ConnectionString;
        }
        public static List<Category> GetCategories()
        {
            List<Category> categoryList = new List<Category>();
            string sql = "SELECT CategoryID, ShortName, LongName "
                + "FROM Categories ORDER BY LongName";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Category category;
                    while (dr.Read())
                    {
                        category = new Category();
                        category.CategoryID = dr["CategoryID"].ToString();
                        category.ShortName = dr["ShortName"].ToString();
                        category.LongName = dr["LongName"].ToString();
                        categoryList.Add(category);
                    }
                    dr.Close();
                }
            }
            return categoryList;
        }

        public static Category GetCategoryByID(string catID)
        {
            Category category = null;
            string sql = "SELECT CategoryID, ShortName, LongName "
                + "FROM Categories WHERE CategoryID = @CategoryID";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", catID);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        category = new Category();
                        category.CategoryID = dr["CategoryID"].ToString();
                        category.ShortName = dr["ShortName"].ToString();
                        category.LongName = dr["LongName"].ToString();
                    }
                    dr.Close();
                }
            }
            return category;
        }

        public static void InsertCategory(Category category)
        {
            string sql = "INSERT INTO Categories "
                + "(CategoryID, ShortName, LongName) "
                + "VALUES (@CategoryID, @ShortName, @LongName)";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("CategoryID", category.CategoryID);
                    cmd.Parameters.AddWithValue("ShortName", category.ShortName);
                    cmd.Parameters.AddWithValue("LongName", category.LongName);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static int DeleteCategory(Category category)
        {
            int deleteCount = 0;
            string sql = "DELETE FROM Categories "
                + "WHERE CategoryID = @CategoryID "
                + "AND ShortName = @ShortName "
                + "AND LongName = @LongName";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("CategoryID", category.CategoryID);
                    cmd.Parameters.AddWithValue("ShortName", category.ShortName);
                    cmd.Parameters.AddWithValue("LongName", category.LongName);
                    con.Open();
                    deleteCount = cmd.ExecuteNonQuery();
                }
            }
            return deleteCount;
        }
        public static int UpdateCategory(Category original_Category,
            Category category)
        {
            int updateCount = 0;
            string sql = "UPDATE Categories "
                + "SET ShortName = @ShortName, "
                + "LongName = @LongName "
                + "WHERE CategoryID = @original_CategoryID "
                + "AND ShortName = @original_ShortName "
                + "AND LongName = @original_LongName";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("ShortName", category.ShortName);
                    cmd.Parameters.AddWithValue("LongName", category.LongName);
                    cmd.Parameters.AddWithValue("original_CategoryID",
                        original_Category.CategoryID);
                    cmd.Parameters.AddWithValue("original_ShortName",
                        original_Category.ShortName);
                    cmd.Parameters.AddWithValue("original_LongName",
                        original_Category.LongName);
                    con.Open();
                    updateCount = cmd.ExecuteNonQuery();
                }
            }
            return updateCount;
        }

    }
}