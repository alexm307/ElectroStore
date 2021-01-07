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
    Public Class RefrigeratorsController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: Refrigerators
        Function Index() As ActionResult
            Dim refrigerators = db.Refrigerators.Include(Function(r) r.KitchenAppliance)
            Return View(refrigerators.ToList())
        End Function

        ' GET: Refrigerators/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim refrigerator As Refrigerator = db.Refrigerators.Find(id)
            If IsNothing(refrigerator) Then
                Return HttpNotFound()
            End If
            Return View(refrigerator)
        End Function

        ' GET: Refrigerators/Create
        Function Create() As ActionResult
            ViewBag.RefrigeratorID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID")
            Return View()
        End Function

        ' POST: Refrigerators/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="RefrigeratorID,Volume,SpecialCompartiments,NoOfShelves")> ByVal refrigerator As Refrigerator) As ActionResult
            If ModelState.IsValid Then
                db.Refrigerators.Add(refrigerator)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.RefrigeratorID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", refrigerator.RefrigeratorID)
            Return View(refrigerator)
        End Function

        ' GET: Refrigerators/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim refrigerator As Refrigerator = db.Refrigerators.Find(id)
            If IsNothing(refrigerator) Then
                Return HttpNotFound()
            End If
            ViewBag.RefrigeratorID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", refrigerator.RefrigeratorID)
            Return View(refrigerator)
        End Function

        ' POST: Refrigerators/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="RefrigeratorID,Volume,SpecialCompartiments,NoOfShelves")> ByVal refrigerator As Refrigerator) As ActionResult
            If ModelState.IsValid Then
                db.Entry(refrigerator).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.RefrigeratorID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", refrigerator.RefrigeratorID)
            Return View(refrigerator)
        End Function

        ' GET: Refrigerators/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim refrigerator As Refrigerator = db.Refrigerators.Find(id)
            If IsNothing(refrigerator) Then
                Return HttpNotFound()
            End If
            Return View(refrigerator)
        End Function

        ' POST: Refrigerators/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim refrigerator As Refrigerator = db.Refrigerators.Find(id)
            db.Refrigerators.Remove(refrigerator)
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
