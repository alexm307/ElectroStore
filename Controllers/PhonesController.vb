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
    Public Class PhonesController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: Phones
        Function Index() As ActionResult
            Dim phones = db.Phones.Include(Function(p) p.ElectronicProduct)
            Return View(phones.ToList())
        End Function

        ' GET: Phones/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim phone As Phone = db.Phones.Find(id)
            If IsNothing(phone) Then
                Return HttpNotFound()
            End If
            Return View(phone)
        End Function

        ' GET: Phones/Create
        Function Create() As ActionResult
            ViewBag.PhoneID = New SelectList(db.ElectronicProducts, "ProductID", "Name")
            Return View()
        End Function

        ' POST: Phones/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="PhoneID,PhoneCPU,Battery_mAh,Display,Storage_GB,Size_inches")> ByVal phone As Phone) As ActionResult
            If ModelState.IsValid Then
                db.Phones.Add(phone)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PhoneID = New SelectList(db.ElectronicProducts, "ProductID", "Name", phone.PhoneID)
            Return View(phone)
        End Function

        ' GET: Phones/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim phone As Phone = db.Phones.Find(id)
            If IsNothing(phone) Then
                Return HttpNotFound()
            End If
            ViewBag.PhoneID = New SelectList(db.ElectronicProducts, "ProductID", "Name", phone.PhoneID)
            Return View(phone)
        End Function

        ' POST: Phones/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="PhoneID,PhoneCPU,Battery_mAh,Display,Storage_GB,Size_inches")> ByVal phone As Phone) As ActionResult
            If ModelState.IsValid Then
                db.Entry(phone).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PhoneID = New SelectList(db.ElectronicProducts, "ProductID", "Name", phone.PhoneID)
            Return View(phone)
        End Function

        ' GET: Phones/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim phone As Phone = db.Phones.Find(id)
            If IsNothing(phone) Then
                Return HttpNotFound()
            End If
            Return View(phone)
        End Function

        ' POST: Phones/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim phone As Phone = db.Phones.Find(id)
            db.Phones.Remove(phone)
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
