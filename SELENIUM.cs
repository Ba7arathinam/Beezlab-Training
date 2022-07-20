﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniummmm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.theloopdutyfree.co.nz/electronics/apple/?lang=en_NZ");
            

            IList<IWebElement> product = driver.FindElements(By.ClassName("b-product__brand-name-link"));
            IList<IWebElement> productDetail = driver.FindElements(By.ClassName("b-product__product-name-link"));
            IList<IWebElement> price = driver.FindElements(By.ClassName("b-price__sales-price"));


            String[] productText = new String[product.Count];
            String[] productDetailText = new String[productDetail.Count];
            String[] priceText = new String[price.Count];

            for (int i = 0; i < product.Count; i++)
            {
                productText[i] = product[i].Text;
                productDetailText[i] = productDetail[i].Text;
                priceText[i] = price[i].Text;
            }
            for (int i = 0; i < product.Count; i++)
            {
                Console.WriteLine(i + 1);
                Console.WriteLine("PRODUCT NAME :" + product[i].Text);
                Console.WriteLine("PRODUCT DETAIL :" + productDetail[i].Text);
                Console.WriteLine("PRODUCT PRICE :" + price[i].Text);





            }


        }
    }
}