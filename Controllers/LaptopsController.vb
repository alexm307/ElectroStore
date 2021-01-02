Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ElectroStore2

Namespace Controllers
    Public Class LaptopsController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: Laptops
        Function Index() As ActionResult
            Dim laptops = db.Laptops.Include(Function(l) l.C2in1Laptops).Include(Function(l) l.ElectronicProduct).Include(Function(l) l.GamingLaptop).Include(Function(l) l.LaptopCPU).Include(Function(l) l.LaptopGPU)
            Return View(laptops.ToList())
        End Function

        ' GET: Laptops/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptop As Laptop = db.Laptops.Find(id)
            If IsNothing(laptop) Then
                Return HttpNotFound()
            End If
            Return View(laptop)
        End Function

        ' GET: Laptops/Create
        Function Create() As ActionResult
            ViewBag.LaptopID = New SelectList(db.C2in1Laptops, "C2in1ID", "Touchscreen")
            ViewBag.LaptopID = New SelectList(db.ElectronicProducts, "ProductID", "Name")
            ViewBag.LaptopID = New SelectList(db.GamingLaptops, "GamingLaptopID", "GamingLaptopID")
            ViewBag.CPU = New SelectList(db.LaptopCPUs, "LaptopCPUID", "Brand")
            ViewBag.GPU = New SelectList(db.LaptopGPUs, "LaptopGPUID", "Brand")
            Return View()
        End Function

        ' POST: Laptops/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="LaptopID,Brand,RAM,CPU,GPU,Battery,Display,Storage_GB,DisplaySize_inches")> ByVal laptop As Laptop) As ActionResult
            If ModelState.IsValid Then
                db.Laptops.Add(laptop)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.LaptopID = New SelectList(db.C2in1Laptops, "C2in1ID", "Touchscreen", laptop.LaptopID)
            ViewBag.LaptopID = New SelectList(db.ElectronicProducts, "ProductID", "Name", laptop.LaptopID)
            ViewBag.LaptopID = New SelectList(db.GamingLaptops, "GamingLaptopID", "GamingLaptopID", laptop.LaptopID)
            ViewBag.CPU = New SelectList(db.LaptopCPUs, "LaptopCPUID", "Brand", laptop.CPU)
            ViewBag.GPU = New SelectList(db.LaptopGPUs, "LaptopGPUID", "Brand", laptop.GPU)
            Return View(laptop)
        End Function

        ' GET: Laptops/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptop As Laptop = db.Laptops.Find(id)
            If IsNothing(laptop) Then
                Return HttpNotFound()
            End If
            ViewBag.LaptopID = New SelectList(db.C2in1Laptops, "C2in1ID", "Touchscreen", laptop.LaptopID)
            ViewBag.LaptopID = New SelectList(db.ElectronicProducts, "ProductID", "Name", laptop.LaptopID)
            ViewBag.LaptopID = New SelectList(db.GamingLaptops, "GamingLaptopID", "GamingLaptopID", laptop.LaptopID)
            ViewBag.CPU = New SelectList(db.LaptopCPUs, "LaptopCPUID", "Brand", laptop.CPU)
            ViewBag.GPU = New SelectList(db.LaptopGPUs, "LaptopGPUID", "Brand", laptop.GPU)
            Return View(laptop)
        End Function

        ' POST: Laptops/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="LaptopID,Brand,RAM,CPU,GPU,Battery,Display,Storage_GB,DisplaySize_inches")> ByVal laptop As Laptop) As ActionResult
            If ModelState.IsValid Then
                db.Entry(laptop).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.LaptopID = New SelectList(db.C2in1Laptops, "C2in1ID", "Touchscreen", laptop.LaptopID)
            ViewBag.LaptopID = New SelectList(db.ElectronicProducts, "ProductID", "Name", laptop.LaptopID)
            ViewBag.LaptopID = New SelectList(db.GamingLaptops, "GamingLaptopID", "GamingLaptopID", laptop.LaptopID)
            ViewBag.CPU = New SelectList(db.LaptopCPUs, "LaptopCPUID", "Brand", laptop.CPU)
            ViewBag.GPU = New SelectList(db.LaptopGPUs, "LaptopGPUID", "Brand", laptop.GPU)
            Return View(laptop)
        End Function

        ' GET: Laptops/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptop As Laptop = db.Laptops.Find(id)
            If IsNothing(laptop) Then
                Return HttpNotFound()
            End If
            Return View(laptop)
        End Function

        ' POST: Laptops/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim laptop As Laptop = db.Laptops.Find(id)
            db.Laptops.Remove(laptop)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
