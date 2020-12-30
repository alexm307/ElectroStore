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
    Public Class ElectronicProductsController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: ElectronicProducts
        Function Index() As ActionResult
            Dim electronicProducts = db.ElectronicProducts.Include(Function(e) e.KitchenAppliance).Include(Function(e) e.Laptop).Include(Function(e) e.Phone)
            Return View(electronicProducts.ToList())
        End Function

        ' GET: ElectronicProducts/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim electronicProduct As ElectronicProduct = db.ElectronicProducts.Find(id)
            If IsNothing(electronicProduct) Then
                Return HttpNotFound()
            End If
            Return View(electronicProduct)
        End Function

        ' GET: ElectronicProducts/Create
        Function Create() As ActionResult
            ViewBag.ProductID = New SelectList(db.KitchenAppliances, "ApplianceID", "EuEnergyLabel")
            ViewBag.ProductID = New SelectList(db.Laptops, "LaptopID", "Brand")
            ViewBag.ProductID = New SelectList(db.Phones, "PhoneID", "PhoneCPU")
            Return View()
        End Function

        ' POST: ElectronicProducts/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ProductID,Name,Price,Rating,Quantity,Colour")> ByVal electronicProduct As ElectronicProduct) As ActionResult
            If ModelState.IsValid Then
                db.ElectronicProducts.Add(electronicProduct)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ProductID = New SelectList(db.KitchenAppliances, "ApplianceID", "EuEnergyLabel", electronicProduct.ProductID)
            ViewBag.ProductID = New SelectList(db.Laptops, "LaptopID", "Brand", electronicProduct.ProductID)
            ViewBag.ProductID = New SelectList(db.Phones, "PhoneID", "PhoneCPU", electronicProduct.ProductID)
            Return View(electronicProduct)
        End Function

        ' GET: ElectronicProducts/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim electronicProduct As ElectronicProduct = db.ElectronicProducts.Find(id)
            If IsNothing(electronicProduct) Then
                Return HttpNotFound()
            End If
            ViewBag.ProductID = New SelectList(db.KitchenAppliances, "ApplianceID", "EuEnergyLabel", electronicProduct.ProductID)
            ViewBag.ProductID = New SelectList(db.Laptops, "LaptopID", "Brand", electronicProduct.ProductID)
            ViewBag.ProductID = New SelectList(db.Phones, "PhoneID", "PhoneCPU", electronicProduct.ProductID)
            Return View(electronicProduct)
        End Function

        ' POST: ElectronicProducts/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ProductID,Name,Price,Rating,Quantity,Colour")> ByVal electronicProduct As ElectronicProduct) As ActionResult
            If ModelState.IsValid Then
                db.Entry(electronicProduct).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ProductID = New SelectList(db.KitchenAppliances, "ApplianceID", "EuEnergyLabel", electronicProduct.ProductID)
            ViewBag.ProductID = New SelectList(db.Laptops, "LaptopID", "Brand", electronicProduct.ProductID)
            ViewBag.ProductID = New SelectList(db.Phones, "PhoneID", "PhoneCPU", electronicProduct.ProductID)
            Return View(electronicProduct)
        End Function

        ' GET: ElectronicProducts/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim electronicProduct As ElectronicProduct = db.ElectronicProducts.Find(id)
            If IsNothing(electronicProduct) Then
                Return HttpNotFound()
            End If
            Return View(electronicProduct)
        End Function

        ' POST: ElectronicProducts/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim electronicProduct As ElectronicProduct = db.ElectronicProducts.Find(id)
            db.ElectronicProducts.Remove(electronicProduct)
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
