﻿using System;
using System.Text;
using System.Security.Cryptography;

namespace mvc4.Account{
    class CriptoUtil{
            public static string HashData(string data){
	            var hasher = SHA256.Create();
	            var hashedData = hasher.ComputeHash(
									Encoding.Unicode.GetBytes(data)
								);
	            // Now we'll make it into a hexadecimal string for saving
	            var sb = new StringBuilder(hashedData.Length * 2);
	            foreach (var b in hashedData){
	                sb.AppendFormat("{0:x2}", b );
	            }
	            return sb.ToString();
	        }

            public static string HashLogin(string userName, string password){
	            // Use the first 4 letters of the userName for a salt
	            return HashData(String.Format("{0}{1}", userName.Substring(0, 4), password));
	        }

            public static bool IsValidPassword(string userName, string password, string hashedPasswordFromDb){
	            return (String.CompareOrdinal(hashedPasswordFromDb, HashLogin(userName, password)) == 0);
	        }
	    }
	}
