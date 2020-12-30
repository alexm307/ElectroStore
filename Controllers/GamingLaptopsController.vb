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
    Public Class GamingLaptopsController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: GamingLaptops
        Function Index() As ActionResult
            Dim gamingLaptops = db.GamingLaptops.Include(Function(g) g.Laptop)
            Return View(gamingLaptops.ToList())
        End Function

        ' GET: GamingLaptops/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim gamingLaptop As GamingLaptop = db.GamingLaptops.Find(id)
            If IsNothing(gamingLaptop) Then
                Return HttpNotFound()
            End If
            Return View(gamingLaptop)
        End Function

        ' GET: GamingLaptops/Create
        Function Create() As ActionResult
            ViewBag.GamingLaptopID = New SelectList(db.Laptops, "LaptopID", "Brand")
            Return View()
        End Function

        ' POST: GamingLaptops/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="GamingLaptopID,RefreshRate_Hz,ResponseTime_ms")> ByVal gamingLaptop As GamingLaptop) As ActionResult
            If ModelState.IsValid Then
                db.GamingLaptops.Add(gamingLaptop)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.GamingLaptopID = New SelectList(db.Laptops, "LaptopID", "Brand", gamingLaptop.GamingLaptopID)
            Return View(gamingLaptop)
        End Function

        ' GET: GamingLaptops/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim gamingLaptop As GamingLaptop = db.GamingLaptops.Find(id)
            If IsNothing(gamingLaptop) Then
                Return HttpNotFound()
            End If
            ViewBag.GamingLaptopID = New SelectList(db.Laptops, "LaptopID", "Brand", gamingLaptop.GamingLaptopID)
            Return View(gamingLaptop)
        End Function

        ' POST: GamingLaptops/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="GamingLaptopID,RefreshRate_Hz,ResponseTime_ms")> ByVal gamingLaptop As GamingLaptop) As ActionResult
            If ModelState.IsValid Then
                db.Entry(gamingLaptop).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.GamingLaptopID = New SelectList(db.Laptops, "LaptopID", "Brand", gamingLaptop.GamingLaptopID)
            Return View(gamingLaptop)
        End Function

        ' GET: GamingLaptops/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim gamingLaptop As GamingLaptop = db.GamingLaptops.Find(id)
            If IsNothing(gamingLaptop) Then
                Return HttpNotFound()
            End If
            Return View(gamingLaptop)
        End Function

        ' POST: GamingLaptops/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim gamingLaptop As GamingLaptop = db.GamingLaptops.Find(id)
            db.GamingLaptops.Remove(gamingLaptop)
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
