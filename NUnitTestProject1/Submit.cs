using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;
        IWebElement vardas;
        IWebElement pavarde;
        IWebElement asmensKodas;
        IWebElement adresas;
        IWebElement telefonoNumeris;
        IWebElement radioVyr;
        IWebElement radioMot;
        IWebElement studPrograma;
        IWebElement studForma;
        IWebElement errorLabel;
        IWebElement mygtukas;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            driver.Url = "https://localhost:44360/";
            vardas = driver.FindElement(By.Id("MainContent_nameField"));
            pavarde = driver.FindElement(By.Id("MainContent_surnameField"));
            asmensKodas = driver.FindElement(By.Id("MainContent_asmensKodoFiels"));
            adresas = driver.FindElement(By.Id("MainContent_addressField"));
            telefonoNumeris = driver.FindElement(By.Id("MainContent_phoneField"));
            radioVyr = driver.FindElement(By.Id("MainContent_RadioButton1"));
            radioMot = driver.FindElement(By.Id("MainContent_RadioButton2"));
            studPrograma = driver.FindElement(By.Id("MainContent_studijuField"));
            studForma = driver.FindElement(By.Id("MainContent_formaField"));
            errorLabel = driver.FindElement(By.Id("MainContent_errorLabel"));
            mygtukas = driver.FindElement(By.Id("MainContent_registerButton"));
        }

        [Test]
        [Order(1)]
        public void SubmitButtonClick_EmptyFields()
        {
            mygtukas.Click();
            Assert.AreEqual("Iveskite varda",errorLabel);
        }

        //[Test]
        //[Order(2)]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        //[Order(3)]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        //[Order(4)]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        //[Order(5)]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}