﻿using VaksinApp.Models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VaksinApp.VaksinRegistService;
using VaksinApp.CekNikService;
using VaksinDataService = VaksinApp.VaksinRegistService.VaksinData;
using ServiceClientRegistrasi = VaksinApp.VaksinRegistService.Service1Client;
using ServiceClientNik = VaksinApp.CekNikService.Service1Client;
using ServiceClientKonfir = VaksinApp.KonfirmVaksinService.Service1Client;
using Data_Pasien = VaksinApp.KonfirmVaksinService.Data_Pasien;

namespace VaksinApp.Controllers
{
    public class UserController : Controller
    {
        
        ServiceClientRegistrasi sc = new ServiceClientRegistrasi();
        ServiceClientNik scNik = new ServiceClientNik();
        ServiceClientKonfir sck = new ServiceClientKonfir();

        [Authorize(Roles = "Masyarakat, Produsen, BPOM, RumahSakit")]
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Akun");
        }
        [Authorize(Roles = "Masyarakat, Produsen, BPOM, RumahSakit")]

        public ActionResult Vaksin()
        {
            List<VaksinDataService> li = sc.GetVaksin().ToList();
            ViewBag.vaksin = li;
            return View();
        }
        [HttpGet]
        public ActionResult Vaksin(string search)
        {
            List<VaksinDataService> li = sc.GetVaksin().ToList();
            ViewBag.vaksin = li;
            if (!String.IsNullOrEmpty(search))
            {
                li = li.Where(n => n.no_register.Contains(search)).Select(n => new VaksinDataService
                {
                    no_register = n.no_register,
                    tanggal_dibuat = n.tanggal_dibuat
                }).ToList();
                if (li.Any(n => n.no_register != null))
                {
                    ViewBag.vaksin = li;
                }
                else
                {
                    ViewBag.error = "Nomor Registrasi Vaksin Tidak terdaftar";
                }

            }
            return View(li.ToList());

        }

        public ActionResult insertVaksin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insertVaksin(FormCollection formCollection)
        {
            string no_register = formCollection["no_register"];

            VaksinData vaksin = new VaksinData{ no_register = no_register};
            sc.InsertVaksin(vaksin);
            return RedirectToAction("Vaksin", "User");
        }
        public ActionResult updateVaksin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult deleteVaksin(string id)
        {
            sc.DeleteVaksin(id);
            return RedirectToAction("Vaksin", "User");
        }
        public ActionResult Nik()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Nik(string search)
        {
            List<Data_Penduduk> li = scNik.GetNik().ToList();
            ViewBag.nik = li;
            if (!String.IsNullOrEmpty(search))
            {
                if (scNik.CekNik(search) == true)
                {
                    li = li.Where(n => n.nik.Contains(search)).Select(n => new Data_Penduduk
                    {
                        id = n.id,
                        nik = n.nik,
                        nama = n.nama,
                        alamat = n.alamat,
                        jenis_kelamin = n.jenis_kelamin
                    }).ToList();
                    ViewBag.nik = li;
                }
                else
                {
                    ViewBag.error = "Data NIK Tidak terdaftar";
                }
            }
            return View(li.ToList());

        }

        public ActionResult Konfirmasi()
        {
            List<VaksinDataService> li = sc.GetVaksin().ToList();
            return View(li);

        }

        public ActionResult addVaksinSampai(VaksinData vaksinData)
        {

            if (Session["vaksin"] == null)
            {
                List<VaksinData> li = new List<VaksinData>();
                li.Add(vaksinData);
                Session["vaksin"] = li;

            }
            else
            {
                List<VaksinData> li = (List<VaksinData>)Session["vaksin"];
                li.Add(vaksinData);
                Session["vaksin"] = li;

            }


            return RedirectToAction("Konfirmasi", "User");
        }
        public ActionResult vaksinSampai()
        {
            ViewData["isHideButton"] = true;
            return View((List<VaksinData>)Session["vaksin"]);

        }
        public ActionResult insertLaporan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insertLaporan(Data_Pasien obj)
        {
            sck.InsertLaporan(obj);
            return RedirectToAction("Vaksin", "User");
        }

        public ActionResult vaksinDigunakan()
        {
            List<Data_Pasien> li = sck.GetPasien().ToList();
            return View(li);
        }
    }
}