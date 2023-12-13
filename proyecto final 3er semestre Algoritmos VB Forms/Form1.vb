Public Class Form1
    Private array As Integer() = {9, 1, 8, 2, 7}
    Private stopwatch As Stopwatch = New Stopwatch
    Private Sub btnHeap_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage12_Click(sender As Object, e As EventArgs) Handles TabPage12.Click

    End Sub

    Private Sub btnMerge_Click(sender As Object, e As EventArgs)

    End Sub
    Public Shared Sub PrintArray(ByVal array As Integer(), ByVal txtBox As TextBox)
        txtBox.Text += ("[" + String.Join(", ", array) + "]" + vbCrLf)
    End Sub
    Private Function ArrayReset(ByVal arr As Integer()) As Integer()
        arr(0) = 9
        arr(1) = 1
        arr(2) = 8
        arr(3) = 2
        arr(4) = 7
        Return arr
    End Function

    Private Sub btnInsertionSort_Click(sender As Object, e As EventArgs) Handles btnInsertionSort.Click
        Dim insertionSort As New InsertionSort()
        txtInsertionSort.Text = String.Empty
        stopwatch.Reset()
        txtInsertionSort.Text += "Arreglo inicial: "
        PrintArray(Array, txtInsertionSort)
        stopwatch.Start()
        insertionSort.InsertionSortAlgorithm(Array)
        stopwatch.Stop()
        txtInsertionSort.Text += "Arreglo ordenado: "
        PrintArray(Array, txtInsertionSort)
        txtInsertionSort.Text += "Tiempo de ejecucion del metodo InsertionSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(Array)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtSelection.Text = String.Empty
        Dim selection_Sort As New SelectionSort()
        stopwatch.Reset()
        txtSelection.Text += "Arreglo inicial: "
        PrintArray(array, txtSelection)
        stopwatch.Start()
        selection_Sort.Sort(array)
        stopwatch.Stop()
        txtSelection.Text += "Arreglo ordenado: "
        PrintArray(array, txtSelection)
        txtSelection.Text += "Tiempo de ejecucion del metodo SelectionSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnRadixSort_Click(sender As Object, e As EventArgs) Handles btnRadixSort.Click
        txtRadix.Text = String.Empty
        Dim radixSort As New RadixSort()
        stopwatch.Reset()
        txtRadix.Text += "Arreglo inicial: "
        PrintArray(array, txtRadix)
        stopwatch.Start()
        radixSort.Sort(array)
        stopwatch.Stop()
        txtRadix.Text += "Arreglo ordenado: "
        PrintArray(array, txtRadix)
        txtRadix.Text += "Tiempo de ejecucion del metodo RadixSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnQuickSort_Click(sender As Object, e As EventArgs) Handles btnQuickSort.Click
        txtQuick.Text = String.Empty
        Dim quickSort As New QuickSort()
        stopwatch.Reset()
        txtQuick.Text += "Arreglo inicial: "
        PrintArray(array, txtQuick)
        stopwatch.Start()
        quickSort.quicksort(array, 0, 4, txtQuick)
        stopwatch.Stop()
        txtQuick.Text += "Arreglo ordenado: "
        PrintArray(array, txtQuick)
        txtQuick.Text += "Tiempo de ejecucion del metodo QuickSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnShellSort_Click(sender As Object, e As EventArgs) Handles btnShellSort.Click
        txtShell.Text = String.Empty
        Dim shellSort As New ShellSort()
        stopwatch.Reset()
        txtShell.Text += "Arreglo inicial: "
        PrintArray(array, txtShell)
        stopwatch.Start()
        shellSort.ShellSortAlgorithm(array, txtShell)
        stopwatch.Stop()
        txtShell.Text += vbCrLf + "Arreglo ordenado: "
        PrintArray(array, txtShell)
        txtShell.Text += "Tiempo de ejecucion del metodo ShellSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnBinaryTreeSort_Click(sender As Object, e As EventArgs) Handles btnBinaryTreeSort.Click
        txtBinaryTree.Text = String.Empty
        PrintArray(array, txtBinaryTree)
        Dim binaryTree As New BinaryTreeSort()
        stopwatch.Restart()
        stopwatch.Start()
        binaryTree.Sort(array)
        stopwatch.Stop()
        PrintArray(array, txtBinaryTree)
        txtBinaryTree.Text += "Tiempo de ejecucion del Método Binary Tree Sort = " & stopwatch.Elapsed.ToString
        ArrayReset(array)
    End Sub

    Private Sub btnBucketSort_Click(sender As Object, e As EventArgs) Handles btnBucketSort.Click
        Dim bucketSort As New BucketSort
        txtBucket.Text = String.Empty
        stopwatch.Reset()
        txtBucket.Text += ("Arreglo inicial: ")
        PrintArray(array, txtBucket)
        stopwatch.Start()
        bucketSort.BucketSort_int(array, txtBucket)
        stopwatch.Stop()
        txtBucket.Text += ("Arreglo ordenado: ")
        PrintArray(array, txtBucket)
        txtBucket.Text += ("Tiempo de ejecución del método BucketSort() = " + stopwatch.Elapsed.ToString())
        ArrayReset(array)
    End Sub

    Private Sub btnCombSort_Click(sender As Object, e As EventArgs) Handles btnCombSort.Click
        Dim combSort As New CombSort()
        txtComb.Text = String.Empty
        stopwatch.Reset()
        txtComb.Text += "Arreglo inicial: "
        PrintArray(array, txtComb)
        stopwatch.Start()
        combSort.Sort(array)
        stopwatch.Stop()
        txtComb.Text += "Arreglo ordenado: "
        PrintArray(array, txtComb)
        txtComb.Text += "Tiempo de ejecucion del metodo CombSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnCountingSort_Click(sender As Object, e As EventArgs) Handles btnCountingSort.Click
        Dim countingSort As New CountingSort()
        txtCounting.Text = String.Empty
        stopwatch.Reset()
        txtCounting.Text += "Arreglo inicial: "
        PrintArray(array, txtCounting)
        stopwatch.Start()
        countingSort.Sort(array)
        stopwatch.Stop()
        txtCounting.Text += "Arreglo ordenado: "
        PrintArray(array, txtCounting)
        txtCounting.Text += "Tiempo de ejecucion del metodo CountingSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnPigeonSort_Click(sender As Object, e As EventArgs) Handles btnPigeonSort.Click
        Dim pigeonHole As New PigeonHole()
        txtPigeon.Text = String.Empty
        stopwatch.Reset()
        txtPigeon.Text += "Arreglo inicial: "
        PrintArray(array, txtPigeon)
        stopwatch.Start()
        pigeonHole.PigeonholeSort(array)
        stopwatch.Stop()
        txtPigeon.Text += "Arreglo ordenado: "
        PrintArray(array, txtPigeon)
        txtPigeon.Text += "Tiempo de ejecucion del metodo PigeonHoleSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnCocktailSort_Click(sender As Object, e As EventArgs) Handles btnCocktailSort.Click
        Dim cocktailSort As New CocktailSort()
        txtCocktail.Text = String.Empty
        stopwatch.Reset()
        txtCocktail.Text += "Arreglo inicial: "
        PrintArray(array, txtCocktail)
        stopwatch.Start()
        cocktailSort.CocktailSort(array)
        stopwatch.Stop()
        txtCocktail.Text += "Arreglo ordenado: "
        PrintArray(array, txtCocktail)
        txtCocktail.Text += "Tiempo de ejecucion del metodo CocktailSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub txtCocktailSort_TextChanged(sender As Object, e As EventArgs) Handles txtCocktail.TextChanged

    End Sub

    Private Sub btnHeap_Click_1(sender As Object, e As EventArgs) Handles btnHeap.Click
        Dim heapSort As New HeapSort()
        txtHeap.Text = String.Empty
        stopwatch.Reset()
        txtHeap.Text += "Arreglo inicial: "
        PrintArray(array, txtHeap)
        stopwatch.Start()
        heapSort.Sort(array)
        stopwatch.Stop()
        txtHeap.Text += "Arreglo ordenado: "
        PrintArray(array, txtHeap)
        txtHeap.Text += "Tiempo de ejecucion del metodo HeapSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub btnMerge_Click_1(sender As Object, e As EventArgs) Handles btnMerge.Click
        Dim mergeSort As New MergeSort()
        txtMerge.Text = String.Empty
        stopwatch.Reset()
        txtMerge.Text += "Arreglo inicial: "
        PrintArray(array, txtMerge)
        stopwatch.Start()
        mergeSort.MergeSortt(array)
        stopwatch.Stop()
        txtMerge.Text += "Arreglo ordenado: "
        PrintArray(array, txtMerge)
        txtMerge.Text += "Tiempo de ejecucion del metodo MergeSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub

    Private Sub txtHeapSort_TextChanged(sender As Object, e As EventArgs) Handles txtHeap.TextChanged

    End Sub

    Private Sub btnSmoothSort_Click(sender As Object, e As EventArgs) Handles btnSmoothSort.Click
        txtSmooth.Text = String.Empty
        Dim smoothSort As New SmoothSort()
        stopwatch.Reset()
        txtSmooth.Text += "Arreglo inicial: "
        PrintArray(array, txtSmooth)
        stopwatch.Start()
        smoothSort.Sort(array)
        stopwatch.Stop()
        txtSmooth.Text += vbCrLf + "Arreglo ordenado: "
        PrintArray(array, txtSmooth)
        txtSmooth.Text += "Tiempo de ejecucion del metodo SmoothSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub
    Public Shared Sub BubbleSort(ByVal array As Integer(), ByVal txtBox As TextBox)
        txtBox.Text = String.Empty
        txtBox.Text += ("Arreglo inicial: ")
        PrintArray(array, txtBox)

        For i As Integer = 0 To array.Length - 1
            For j As Integer = 0 To array.Length - i - 2
                ' Comparar los elementos adyacentes e intercambiar si el elemento actual es menor que el siguiente
                If array(j) > array(j + 1) Then
                    ' Intercambiar elementos
                    Dim temp As Integer = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp

                    ' Mostrar el estado actual del arreglo
                    txtBox.Text += ("Intercambio - [" + String.Join(", ", array) + "]" + vbCrLf)
                End If
            Next
        Next
        txtBox.Text += ("Arreglo ordenado: ")
        PrintArray(array, txtBox)
    End Sub
    Private Sub btnBubbleSort_Click(sender As Object, e As EventArgs) Handles btnBubbleSort.Click
        txtBubble.Text = String.Empty
        stopwatch.Restart()
        stopwatch.Start()
        BubbleSort(array, txtBubble)
        stopwatch.Stop()
        txtBubble.Text += ("Tiempo de ejecucion del metodo BubbleSort() = " + stopwatch.Elapsed.ToString())
        ArrayReset(array)
    End Sub

    Private Sub btnGnomeSort_Click(sender As Object, e As EventArgs) Handles btnGnomeSort.Click
        Dim gnomeSort As New GnomeSort()
        txtGnome.Text = String.Empty
        stopwatch.Reset()
        txtGnome.Text += "Arreglo inicial: "
        PrintArray(array, txtGnome)
        stopwatch.Start()
        gnomeSort.Sort(array)
        stopwatch.Stop()
        txtGnome.Text += "Arreglo ordenado: "
        PrintArray(array, txtGnome)
        txtGnome.Text += "Tiempo de ejecucion del metodo GnomeSort() = " + stopwatch.Elapsed.ToString()
        ArrayReset(array)
    End Sub
End Class
