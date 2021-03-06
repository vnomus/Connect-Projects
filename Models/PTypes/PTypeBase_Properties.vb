Imports System
Imports System.Runtime.Serialization
Imports DotNetNuke.ComponentModel.DataAnnotations

Namespace Models.PTypes
  <TableName("Connect_Projects_PTypes")>
  <PrimaryKey("TypeId", AutoIncrement:=True)>
  <DataContract()>
  Partial Public Class PTypeBase

#Region " Private Members "
#End Region
	
#Region " Constructors "
  Public Sub New()
  End Sub

  Public Sub New(typeId As Int32, typeDescription As String, typeIcon As String)
   Me.TypeDescription = typeDescription
   Me.TypeIcon = typeIcon
   Me.TypeId = typeId
  End Sub
#End Region
	
#Region " Public Properties "
  <DataMember()>
  Public Property TypeDescription As String = ""
  <DataMember()>
  Public Property TypeIcon As String = ""
  <DataMember()>
  Public Property TypeId As Int32 = -1
#End Region

#Region " Methods "
  Public Sub ReadPTypeBase(ptype As PTypeBase)
   If ptype.TypeDescription IsNot Nothing Then TypeDescription = ptype.TypeDescription
   If ptype.TypeIcon IsNot Nothing Then TypeIcon = ptype.TypeIcon
   If ptype.TypeId > -1 Then TypeId = ptype.TypeId
  End Sub
#End Region

 End Class
End Namespace


