Imports System.Xml
'prueba

Module Module1

    Sub Main()
        Const fic As String = "C:\Vanessa\Pokemon.txt"
        Dim texto As String
        Dim pokemones As String()
        Dim sr As New System.IO.StreamReader(fic)
        texto = sr.ReadToEnd
        sr.Close()
        Dim doc As New XmlDocument
        Dim docDeclaracion = doc.CreateXmlDeclaration("1.0", "UTF-8", "")
        doc.AppendChild(docDeclaracion)
        Dim nodoPokemones = doc.CreateElement("pokemones")
        pokemones = Split(texto, "#")
        Dim i As Integer
        For i = 0 To UBound(pokemones) - 1
            Dim pokemon As String()
            pokemon = Split(pokemones(i), "$")
            Dim nodoPokemon = doc.CreateElement("pokemon")
            Dim atributoNumero = doc.CreateAttribute("numero")
            atributoNumero.Value = pokemon(1)
            nodoPokemon.Attributes.Append(atributoNumero)
            Dim nodoNombre = doc.CreateElement("nombre")
            Dim textoNombre = doc.CreateTextNode(pokemon(0))
            nodoNombre.AppendChild(textoNombre)
            nodoPokemon.AppendChild(nodoNombre)
            Dim nodoTipo = doc.CreateElement("tipo")
            Dim textoTipo = doc.CreateTextNode(pokemon(3))
            nodoPokemon.AppendChild(nodoTipo)
            nodoTipo.AppendChild(textoTipo)
            If pokemon(2) Like "2" Then
                nodoTipo = doc.CreateElement("tipo")
                textoTipo = doc.CreateTextNode(pokemon(4))
                nodoPokemon.AppendChild(nodoTipo)
                nodoTipo.AppendChild(textoTipo)
                Dim nodoAltura = doc.CreateElement("altura")
                Dim textoAltura = doc.CreateTextNode(pokemon(5))
                nodoPokemon.AppendChild(nodoAltura)
                nodoAltura.AppendChild(textoAltura)
                Dim nodoPeso = doc.CreateElement("altura")
                Dim textoPeso = doc.CreateTextNode(pokemon(6))
                nodoPokemon.AppendChild(nodoPeso)
                nodoPeso.AppendChild(textoPeso)
                If pokemon(7) Like "-" Then
                Else
                    Dim nodoEvolucion = doc.CreateElement("evolucion")
                    Dim textoEvolucion = doc.CreateTextNode(pokemon(7))
                    nodoPokemon.AppendChild(nodoEvolucion)
                    nodoEvolucion.AppendChild(textoEvolucion)
                End If
            Else
                Dim nodoAltura = doc.CreateElement("altura")
                Dim textoAltura = doc.CreateTextNode(pokemon(4))
                nodoPokemon.AppendChild(nodoAltura)
                nodoAltura.AppendChild(textoAltura)
                Dim nodoPeso = doc.CreateElement("altura")
                Dim textoPeso = doc.CreateTextNode(pokemon(5))
                nodoPokemon.AppendChild(nodoPeso)
                nodoPeso.AppendChild(textoPeso)
                If pokemon(6) Like "-" Then
                Else
                    Dim nodoEvolucion = doc.CreateElement("evolucion")
                    Dim textoEvolucion = doc.CreateTextNode(pokemon(6))
                    nodoPokemon.AppendChild(nodoEvolucion)
                    nodoEvolucion.AppendChild(textoEvolucion)
                End If

            End If
            nodoPokemones.AppendChild(nodoPokemon)

        Next
        doc.AppendChild(nodoPokemones)
        doc.Save("C:\Vanessa\Pokemons.xml")
        MsgBox("xml creado")

    End Sub

End Module
