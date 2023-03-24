using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Boshoff.exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        abstract class Bank
        { 

        }
        class CentralBank : Bank 
        {
            public CommercialBank _commercialBank;
            public CentralBank()
            {
                
            }
            public void addCommercialBank(CommercialBank commercialBank) 
            {
                _commercialBank = commercialBank;
            }
            public void removeCommercialBank()
            {
                _commercialBank = null;
            }

        }
        class CommercialBank : Bank 
        {
            public Account _account;
            public CommercialBank()
            {
                
            }
            public void addAccount(Account account) 
            {
                _account = account;
            }
            public void removeAccount(Account account) 
            {
                _account = null;
            }
        }
        class SwiftCentralBank : Bank 
        {
            
            public SwiftCentralBank()
            {
                
            }
        }
        class Account 
        {

             
            
            Asset _asset;
            Client _client;
            public Account(string name, string surname, string address, string city, string cf)
            {
                _client = new Client( name, surname, address, city, cf);
            }
            class Client 
            {
                string _name;
                string _surname;
                string _address;
                string _city;
                string _cf;
                public Client(string name, string surname, string address, string city, string cf)
                {
                    _name = name;
                    _surname = surname;
                    _address = address;
                    _city = city;
                    _cf = cf;


                }
            }
                public void addAsset(Asset asset) 
                {
                _asset = asset;
                }
                public void  removeAsset(Asset asset) 
                {
                _asset = null;
                }
                
            
        }
            class Asset 
            {
                public Asset() 
                {
                }
                class FIAT
                { 
                    decimal _amount;
                    decimal _currency;
                    decimal _price;
                    public FIAT()
                    {
                        
                    }
                }
                class Crypto 
                {
                    string _name;
                    decimal _amount;
                    decimal _value;
                }
                class Stock 
                {
                    string _type;
                    decimal _value;
                }
             }
    }
}
