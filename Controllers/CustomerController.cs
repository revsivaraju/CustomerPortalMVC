﻿using CustomerPortalMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerPortalMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                return View("LoginIndex");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(PortfolioDetail customer)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://52.154.243.228/api/Authorization/authenticate/", content))
                {
                    string stringJWT = response.Content.ReadAsStringAsync().Result;
                    JWT jwt = JsonConvert.DeserializeObject<JWT>(stringJWT);
                    if (jwt.Token != null)
                    {
                        HttpContext.Session.SetString("token", jwt.Token);
                        HttpContext.Session.SetString("email", jwt.Email);
                        return RedirectToAction("ViewStockDetails");
                    }
                    else
                    {
                        ViewBag.Message = "Invalid Username or Password";
                        return View("Login");
                    }
                }
            }
        }

        [HttpGet]
        public async Task<IActionResult> ViewStockDetails()
        {
            try
            {
                List<StockDetail> stockList = new List<StockDetail>();

                string baseUrl = "http://52.154.243.228";
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseUrl);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Accept.Add(contentType);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));

                var response = await httpClient.GetAsync("/api/Authorization/GetCustomerByEmail/" + HttpContext.Session.GetString("email"));
                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.NotFound)
                {
                    HttpContext.Session.Clear();
                    ViewBag.Message = "Invalid Username or Password";
                    return View("Login");
                }
                string apiResponse = await response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<PortfolioDetail>(apiResponse);
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                var response2 = await httpClient.PostAsync("http://52.185.64.154/api/CalculateNetWorth/GetStockByCustomer", content);
                string apiresponse2 = await response2.Content.ReadAsStringAsync();
                stockList = JsonConvert.DeserializeObject<List<StockDetail>>(apiresponse2);


                if (stockList.Count == 0)
                {

                    return View("EmptyStock");
                }
                return View(stockList);
            }
            catch (Exception)
            {
                HttpContext.Session.Clear();
                ViewBag.Message = "Session Expired!!";
                return View("Login");
            }
        }

        [HttpGet]
        public async Task<IActionResult> ViewMutualFundDetails()
        {
            try
            {
                List<MutualFundDetail> mutualFundList = new List<MutualFundDetail>();

                string baseUrl = "http://52.154.243.228";
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseUrl);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Accept.Add(contentType);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));

                var response = await httpClient.GetAsync("/api/Authorization/GetCustomerByEmail/" + HttpContext.Session.GetString("email"));
                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.NotFound)
                {
                    HttpContext.Session.Clear();
                    ViewBag.Message = "Invalid Username or Password";
                    return View("Login");
                }
                string apiResponse = await response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<PortfolioDetail>(apiResponse);
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                var response2 = await httpClient.PostAsync("http://52.185.64.154/api/CalculateNetWorth/GetMutualFundByCustomer", content);
                string apiresponse2 = await response2.Content.ReadAsStringAsync();
                mutualFundList = JsonConvert.DeserializeObject<List<MutualFundDetail>>(apiresponse2);

                if (mutualFundList.Count == 0)
                {
                    return View("EmptyMutualFund");
                }
                ViewBag.message = null;
                return View(mutualFundList);
            }
            catch (Exception)
            {
                HttpContext.Session.Clear();
                ViewBag.Message = "Session Expired!!";
                return View("Login");
            }
        }
        
        [HttpGet]
        public async Task<IActionResult> ViewNetWorth()
        {
            try
            {
                string baseUrl = "http://52.154.243.228";
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseUrl);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Accept.Add(contentType);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));

                var response = await httpClient.GetAsync("/api/Authorization/GetCustomerByEmail/" + HttpContext.Session.GetString("email"));
                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.NotFound)
                {
                    HttpContext.Session.Clear();
                    ViewBag.Message = "Invalid Username or Password";
                    return View("Login");
                }
                string apiResponse = await response.Content.ReadAsStringAsync();
                var customer = JsonConvert.DeserializeObject<PortfolioDetail>(apiResponse);
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                var response2 = await httpClient.PostAsync("http://52.185.64.154/api/CalculateNetWorth", content);
                string apiresponse2 = await response2.Content.ReadAsStringAsync();
                ViewBag.Value = JsonConvert.DeserializeObject<int>(apiresponse2);
                return View();
            }
            catch (Exception)
            {
                HttpContext.Session.Clear();
                ViewBag.Message = "Session Expired!!";
                return View("Login");
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> SellStock(int id)
        {
            try
            {
                string baseUrl = "http://52.154.243.228";
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseUrl);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Accept.Add(contentType);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));

                var response = await httpClient.GetAsync("/api/Authorization/GetCustomerByEmail/" + HttpContext.Session.GetString("email"));
                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.NotFound)
                {
                    ViewBag.Message = "Invalid Username or Password";
                    return View("Login");
                }

                var response2 = await httpClient.GetAsync("http://52.185.64.154/api/CalculateNetWorth/sellStock/" + id);

                return RedirectToAction("ViewNetWorth");
            }
            catch (Exception)
            {
                ViewBag.Message = "Session Expired!!";
                return View("Login");
            }
        }

        [HttpGet]
        public async Task<IActionResult> SellMutualFund(int id)
        {
            try
            {
                string baseUrl = "http://52.154.243.228";
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseUrl);
                var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                httpClient.DefaultRequestHeaders.Accept.Add(contentType);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));

                var response = await httpClient.GetAsync("/api/Authorization/GetCustomerByEmail/" + HttpContext.Session.GetString("email"));
                if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.NotFound) 
                {
                    ViewBag.Message = "Invalid Username or Password";
                    return View("Login");
                }

                var response2 = await httpClient.GetAsync("http://52.185.64.154/api/CalculateNetWorth/sellMutualFund/" + id);

                return RedirectToAction("ViewNetWorth");
            }
            catch (Exception)
            {
                ViewBag.Message = "Session Expired!!";
                return View("Login");
            }
        }

        public  IActionResult About()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                return View("LoginAbout");
            }
            return View();
        }
        public IActionResult Contact()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                return View("LoginContact");
            }
            return View();
        }

        public  IActionResult Services()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                return View("LoginServices");
            }
            return View();
        }
        public IActionResult Portfolio()
        {
            return RedirectToAction("ViewStockDetails");
        }

    }

   
}
