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
    Public Class DishwashersController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: Dishwashers
        Function Index() As ActionResult
            Dim dishwashers = db.Dishwashers.Include(Function(d) d.KitchenAppliance)
            Return View(dishwashers.ToList())
        End Function

        ' GET: Dishwashers/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dishwasher As Dishwasher = db.Dishwashers.Find(id)
            If IsNothing(dishwasher) Then
                Return HttpNotFound()
            End If
            Return View(dishwasher)
        End Function

        ' GET: Dishwashers/Create
        Function Create() As ActionResult
            ViewBag.DishwasherID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID")
            Return View()
        End Function

        ' POST: Dishwashers/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="DishwasherID,NoOfPrograms,StepsOfTemperature,LoadingCapacity")> ByVal dishwasher As Dishwasher) As ActionResult
            If ModelState.IsValid Then
                db.Dishwashers.Add(dishwasher)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.DishwasherID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", dishwasher.DishwasherID)
            Return View(dishwasher)
        End Function

        ' GET: Dishwashers/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dishwasher As Dishwasher = db.Dishwashers.Find(id)
            If IsNothing(dishwasher) Then
                Return HttpNotFound()
            End If
            ViewBag.DishwasherID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", dishwasher.DishwasherID)
            Return View(dishwasher)
        End Function

        ' POST: Dishwashers/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="DishwasherID,NoOfPrograms,StepsOfTemperature,LoadingCapacity")> ByVal dishwasher As Dishwasher) As ActionResult
            If ModelState.IsValid Then
                db.Entry(dishwasher).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.DishwasherID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", dishwasher.DishwasherID)
            Return View(dishwasher)
        End Function

        ' GET: Dishwashers/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dishwasher As Dishwasher = db.Dishwashers.Find(id)
            If IsNothing(dishwasher) Then
                Return HttpNotFound()
            End If
            Return View(dishwasher)
        End Function

        ' POST: Dishwashers/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim dishwasher As Dishwasher = db.Dishwashers.Find(id)
            db.Dishwashers.Remove(dishwasher)
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
