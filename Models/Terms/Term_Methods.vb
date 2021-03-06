Imports System
Imports System.Data

Imports DotNetNuke.ComponentModel.DataAnnotations
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Services.Tokens

Namespace Models.Terms
 Partial Public Class Term
  Implements IHydratable
  Implements IPropertyAccess

#Region " IHydratable Methods "
  Public Overridable Sub Fill(dr As IDataReader) Implements IHydratable.Fill

   Description = Convert.ToString(Null.SetNull(dr.Item("Description"), Description))
   Name = Convert.ToString(Null.SetNull(dr.Item("Name"), Name))
   ParentTermID = Convert.ToInt32(Null.SetNull(dr.Item("ParentTermID"), ParentTermID))
   TermId = Convert.ToInt32(Null.SetNull(dr.Item("TermID"), TermId))
   TermLeft = Convert.ToInt32(Null.SetNull(dr.Item("TermLeft"), TermLeft))
   TermRight = Convert.ToInt32(Null.SetNull(dr.Item("TermRight"), TermRight))
   VocabularyID = Convert.ToInt32(Null.SetNull(dr.Item("VocabularyID"), VocabularyID))
   Weight = Convert.ToInt32(Null.SetNull(dr.Item("Weight"), Weight))
   CreatedByUserID = Convert.ToInt32(Null.SetNull(dr.Item("CreatedByUserID"), CreatedByUserID))
   CreatedOnDate = CDate(Null.SetNull(dr.Item("CreatedOnDate"), CreatedOnDate))
   LastModifiedByUserID = Convert.ToInt32(Null.SetNull(dr.Item("LastModifiedByUserID"), LastModifiedByUserID))
   LastModifiedOnDate = CDate(Null.SetNull(dr.Item("LastModifiedOnDate"), LastModifiedOnDate))

  End Sub

  <IgnoreColumn()>
  Public Property KeyID() As Integer Implements IHydratable.KeyID
   Get
    Return TermId
   End Get
   Set(value As Integer)
    TermId = value
   End Set
  End Property
#End Region

#Region " IPropertyAccess Methods "
  Public Overridable Function GetProperty(strPropertyName As String, strFormat As String, formatProvider As System.Globalization.CultureInfo, accessingUser As DotNetNuke.Entities.Users.UserInfo, accessLevel As DotNetNuke.Services.Tokens.Scope, ByRef propertyNotFound As Boolean) As String Implements IPropertyAccess.GetProperty
   Dim outputFormat As String = strFormat
   If strFormat = String.Empty Then
    outputFormat = "D"
   End If
   Select Case strPropertyName.ToLower
    Case "createdbyuserid"
     If CreatedByUserID Is Nothing Then Return ""
     Return CType(CreatedByUserID, Int32).ToString(outputFormat, formatProvider)
    Case "createdondate"
     If CreatedOnDate Is Nothing Then Return ""
     Return CType(CreatedOnDate, Date).ToString(outputFormat, formatProvider)
    Case "description"
     If Description Is Nothing Then Return ""
     Return PropertyAccess.FormatString(CStr(Description), strFormat)
    Case "lastmodifiedbyuserid"
     If LastModifiedByUserID Is Nothing Then Return ""
     Return CType(LastModifiedByUserID, Int32).ToString(outputFormat, formatProvider)
    Case "lastmodifiedondate"
     If LastModifiedOnDate Is Nothing Then Return ""
     Return CType(LastModifiedOnDate, Date).ToString(outputFormat, formatProvider)
    Case "name"
     Return PropertyAccess.FormatString(Name, strFormat)
    Case "parenttermid"
     If ParentTermID Is Nothing Then Return ""
     Return CType(ParentTermID, Int32).ToString(outputFormat, formatProvider)
    Case "termid"
     Return TermId.ToString(outputFormat, formatProvider)
    Case "termleft"
     Return TermLeft.ToString(outputFormat, formatProvider)
    Case "termright"
     Return TermRight.ToString(outputFormat, formatProvider)
    Case "vocabularyid"
     Return VocabularyID.ToString(outputFormat, formatProvider)
    Case "weight"
     Return Weight.ToString(outputFormat, formatProvider)
    Case Else
     propertyNotFound = True
   End Select

   Return Null.NullString
  End Function

  <IgnoreColumn()>
  Public ReadOnly Property Cacheability() As DotNetNuke.Services.Tokens.CacheLevel Implements DotNetNuke.Services.Tokens.IPropertyAccess.Cacheability
   Get
    Return CacheLevel.fullyCacheable
   End Get
  End Property
#End Region

 End Class
End Namespace
