Imports System
Imports System.Runtime.Serialization
Imports DotNetNuke.ComponentModel.DataAnnotations

Namespace Models.Terms
 <TableName("Taxonomy_Terms")>
 <PrimaryKey("TermID", AutoIncrement:=True)>
 <DataContract()>
 Partial Public Class Term

#Region " Constructors "
  Public Sub New()
  End Sub

  Public Sub New(termId As Int32, createdByUserID As Int32, createdOnDate As Date, description As String, lastModifiedByUserID As Int32, lastModifiedOnDate As Date, name As String, parentTermID As Int32, termLeft As Int32, termRight As Int32, vocabularyID As Int32, weight As Int32)
   Me.CreatedByUserID = createdByUserID
   Me.CreatedOnDate = createdOnDate
   Me.Description = description
   Me.LastModifiedByUserID = lastModifiedByUserID
   Me.LastModifiedOnDate = lastModifiedOnDate
   Me.Name = name
   Me.ParentTermID = parentTermID
   Me.TermID = termID
   Me.TermLeft = termLeft
   Me.TermRight = termRight
   Me.VocabularyID = vocabularyID
   Me.Weight = weight
  End Sub
#End Region

#Region " Public Properties "
  Public Property Description As String = ""
  <DataMember()>
  Public Property Name As String = ""
  Public Property ParentTermID As Int32?
  <DataMember()>
  Public Property TermId As Int32 = -1
  Public Property TermLeft As Int32 = -1
  Public Property TermRight As Int32 = -1
  Public Property VocabularyID As Int32 = -1
  Public Property Weight As Int32 = -1
  Public Property CreatedByUserID As Int32? = -1
  Public Property CreatedOnDate As Date?
  Public Property LastModifiedByUserID As Int32? = -1
  Public Property LastModifiedOnDate As Date?
#End Region

 End Class
End Namespace


