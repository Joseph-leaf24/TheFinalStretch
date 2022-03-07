Imports System.Console
Imports System.IO
Module Module1
    Public Class Animal
        Private AName As String
        Private AAge As Integer
        Private AGender As String

        Sub New()
            AName = ""
            AAge = 0
            AGender = ""

        End Sub

        Public Sub SetAName(ByVal Name As String)
            AName = Name
        End Sub

        Public Sub SetAAge(ByVal Age As Integer)
            AAge = Age
        End Sub

        Public Sub SetAGender(ByVal Gender As String)
            AGender = Gender
        End Sub
        Public Sub IncAge(ByVal Age As Integer)
            AAge = Age + 1
        End Sub
        Public Overridable Sub Cry()
            WriteLine("*Dies slowly inside* ")
        End Sub


        Public Function GetAName() As String
            Return AName
        End Function
        Public Function GetAge() As String
            Return AAge
        End Function
        Public Function GetAGender() As String
            Return AGender
        End Function

        Public Function AddNumbers(ByVal Num1 As Decimal, ByVal Num2 As Decimal) As Decimal
            Return Num1 + Num1
        End Function
    End Class

    Public Class Cat
        Inherits Animal

        Private AFurColour As String
        Private ADomesticated As Boolean
        Private ASize As String
        Private ASpeed As Decimal

        Public Sub New()
            AFurColour = ""
            ADomesticated = False
            ASize = ""
            ASpeed = ""
        End Sub
        Public Sub SetFurColour(ByVal Fur As String)
            AFurColour = Fur
        End Sub

        Public Sub SetDomesticated(ByVal Domesticated As Boolean)
            ADomesticated = Domesticated
        End Sub

        Public Sub SetSize(ByVal Size As Decimal)
            ASize = Size
        End Sub

        Public Sub SetSpeed(ByVal Speed As Decimal)
            ASpeed = Speed
        End Sub
        Public Overrides Sub Cry()
            WriteLine("Meow!")
        End Sub
        Public Function GetFurColour() As String
            Return AFurColour
        End Function

        Public Function GetDomesticated() As Boolean
            Return ADomesticated
        End Function

        Public Function GetSize() As String
            Return ASize
        End Function

        Public Function GetSpeed() As Decimal
            Return ASpeed
        End Function
        Public Overloads Function AddNumbers(ByVal Num1 As Decimal, ByVal Num2 As Decimal, ByVal Num3 As Decimal, ByVal Num4 As Decimal) As Decimal
            Return Num1 + Num2 + Num3 + Num4
        End Function
    End Class

    Sub GeneralOperations()
        Dim Cat1 As Cat = New Cat()
        Dim furcolour As String
        Dim size, speed As Decimal
        Dim domesticated As Boolean
        Dim name, age, gender As String

        WriteLine("Press enter to hear the sound of the cat: ")
        ReadKey()
        Cat1.Cry()

        WriteLine("The sum of the numbers is: " & Cat1.AddNumbers(34, 3.2, 5, 45))

        WriteLine("Please enter the name of the cat: ")
        name = ReadLine()
        Cat1.SetAName(name)

        WriteLine("Please enter the age: ")
        age = ReadLine()
        Cat1.SetAAge(age)

        WriteLine("Please enter the gender: ")
        gender = ReadLine()
        Cat1.SetAGender(gender)

        WriteLine("Please enter the fur colour: ")
        furcolour = ReadLine()
        Cat1.SetFurColour(furcolour)

        WriteLine("Is the cat domesticated: ")
        domesticated = ReadLine()
        Cat1.SetDomesticated(domesticated)

        WriteLine("Please enter the size of the cat: ")
        size = ReadLine()
        Cat1.SetSize(size)

        WriteLine("Please enter the speed of the cat: ")
        speed = ReadLine()
        Cat1.SetSpeed(speed)

        WriteLine("Please press enter to see the information: ")
        ReadKey()
        WriteLine("Name: " & Cat1.GetAName)
        WriteLine("Age: " & Cat1.GetAge)
        WriteLine("Gender: " & Cat1.GetAGender)
        WriteLine("Fur colour: " & Cat1.GetFurColour)
        WriteLine("Domesticated: " & Cat1.GetDomesticated)
        WriteLine("Size: " & Cat1.GetSize)
        WriteLine("Speed: " & Cat1.GetSpeed)
        ReadKey()

    End Sub

    Sub ClassMenu()

        Dim Decision As Char = ""
        Do

            WriteLine("Do you want to use the program?[Y/N]")
            Decision = ReadLine()
            Select Case Decision
                Case "Y"

                    Call GeneralOperations()

                Case "N"

                    Exit Sub

                Case Else

                    WriteLine("Incorrect input, please try again: ")
                    Decision = ReadLine()

            End Select
        Loop Until (Decision = "Y") Or (Decision = "N")


    End Sub



    Public Class Person
        Private PFirstName As String
        Private PLastName As String
        Private PAge As Integer
        Private PGender As String
        'Constructor
        Sub New()
            PFirstName = ""
            PLastName = ""
            PAge = 0
            PGender = ""

        End Sub
        'Setters and Getters
        'Setters

        Public Sub SetFirstName(ByVal FirstName As String)
            PFirstName = FirstName
        End Sub

        Public Sub SetLastName(ByVal LastName As String)
            PLastName = LastName
        End Sub
        Public Sub SetAge(ByVal Age As Integer)
            PAge = Age
        End Sub
        Public Sub SetGender(ByVal Gender As String)
            PGender = Gender
        End Sub

        'Additional Methods.
        Public Sub AddAge()
            PAge = PAge + 10
        End Sub
        Public Overridable Sub Complain()
            WriteLine("I am broke")
        End Sub
        'Getters

        Public Function GetFirstName() As String
            Return PFirstName
        End Function

        Public Function GetLastName() As String
            Return PLastName
        End Function

        Public Function GetAge() As String
            Return PAge
        End Function

        Public Function GetGender() As String
            Return PGender
        End Function

    End Class
    'IS-A TEST
    'HAS-A TEST
    Public Class Student
        Inherits Person
        Private StudentClass As String
        Private StudentID As String

        Sub New()
            StudentClass = ""
            StudentID = ""
        End Sub
        'Setters
        Public Sub SetStudentClass(ByVal StudentC As String)
            StudentClass = StudentC

        End Sub
        Public Sub SetStudentID(ByVal SID As String)
            StudentID = SID
        End Sub
        'Additional Setters
        Public Overrides Sub Complain()
            WriteLine("This teacher is serious... ")
        End Sub
        'Getters
        Public Function GetStudentClass() As String
            Return StudentClass
        End Function

        Public Function GetStudentID() As String
            Return StudentID
        End Function
    End Class

    'Recursion:

    Sub RecursiveFunctions()
        Dim NumberIn As Integer
        WriteLine("Please enter a number: [1-12]")
        NumberIn = Console.ReadLine()
        WriteLine(factorial(NumberIn))
        ReadKey()
    End Sub

    Function factorial(ByVal number As Integer) As Integer
        Dim answer As Integer
        If number = 0 Then
            answer = 1
        Else
            answer = number * factorial(number - 1)
        End If
        Return answer
    End Function

    'Queues.
    Dim ArrayQueue(5) As String
    Dim front, rear As Integer
    Sub CreateEmptyQueue()
        front = 0
        rear = 0
    End Sub

    'Enqueue(insert) items in a queue
    Sub InsertIntoQueue(ByVal item As String)
        If rear = ArrayQueue.Length() - 1 Then
            WriteLine("Overflow: Can't insert item, queue is full")
        Else
            If front = 0 And rear = 0 Then
                rear = 1
                front = 1
            Else
                rear = rear + 1

            End If
            ArrayQueue(rear) = item
        End If
    End Sub

    'Dequeue(Delete) items in a stack.
    Sub RemoveFromQueue()
        Dim item As String
        If front = 0 Then 'Check for underflow.
            WriteLine("Underflow: Can't delete, queue is empty.")
        Else
            item = ArrayQueue(front)
            If front = rear Then 'check if only one item left.
                front = 0
                rear = 0
            Else
                front = front + 1 'Increment front by 1
            End If
            WriteLine(item & " has been deleted")
        End If
    End Sub

    'Search for an item in a queue.
    Sub FindItem(ByVal paraSearchItem As String)
        For count = rear To front Step -1
            If ArrayQueue(count) = paraSearchItem Then
                WriteLine(paraSearchItem & " is found at position: " & count)
            End If
        Next
    End Sub

    Sub QueueMenu()
        Dim Choice As Integer = 0
        Dim InsertValue As String = ""
        Dim SearchValue As String = ""
        Dim continueQ As String = ""
        WriteLine("Welcome to the queue menu, please select your options below: ")
        WriteLine("1: Insert into queue.")
        WriteLine("2: Remove an item from the queue.")
        WriteLine("3: Search for an item in the queue.")
        WriteLine("4: Display all items in the queue.")
        Do
            Write("Choice: ")
            Choice = ReadLine()
            Select Case Choice
                Case 1
                    WriteLine("Please enter item to insert into a queue: ")
                    InsertValue = ReadLine()
                    Call InsertIntoQueue(InsertValue)
                    ReadKey()
                Case 2
                    WriteLine("The item has been removed! ")
                    Call RemoveFromQueue()
                    ReadKey()
                Case 3
                    WriteLine("Please enter item you would like to search for: ")
                    SearchValue = ReadLine()
                    Call FindItem(SearchValue)
                    ReadKey()
                Case 4
                    WriteLine("*Items in queue*")
                    WriteLine()
                    For count = rear To front Step -1
                        WriteLine(ArrayQueue(count))
                    Next
                    ReadKey()
            End Select
            WriteLine("Do you want to continue using the program? [Y/N/y/n]")
            continueQ = ReadLine()
        Loop Until (continueQ = "N")
        WriteLine("Thank you for using this part of the program! Please press enter to return to the menu...")
        ReadKey()

    End Sub

    'Binary Trees
    Dim root, free As String
    Dim data(5) As String
    Dim left(5) As String
    Dim right(5) As String
    Sub BinaryTreeInitialisation()
        For i = 1 To 5
            left(i) = "Null"
            right(i) = "Null"
            data(i) = ""
        Next

        free = 1
        root = 0
    End Sub

    Sub BinaryTreeInsertion(ByVal newitem As String)
        'Variables to be used
        Dim leftcheck As Boolean = False
        Dim rightcheck As Boolean = False
        Dim current As String = ""
        Dim previous As String = ""

        'Place item at free position in array.
        data(free) = newitem
        'Set new root if inserting item at root of an empty binary tree
        If root = 0 Then
            root = free
        Else
            'Use pointer current to go to each node, starting at root.
            current = root
            While current <> "Null"
                'Use pointer previous to keep track of insertion position
                previous = current
                If newitem < data(current) Then
                    current = left(current)
                    'Use boolean value to know whether inserting left of sub tree
                    If current = "Null" Then
                        leftcheck = True
                    End If

                Else
                    current = right(current)
                    'Use boolean value to know whether inserting right of sub-tree
                    If current = "Null" Then
                        rightcheck = True

                    End If
                End If
            End While
        End If

        'Link the new item to the existing binary tree
        If leftcheck = True Then
            left(previous) = free

        End If
        If rightcheck = True Then
            right(previous) = free
        End If
        'Find next free position.
        For index = 1 To 5
            If data(index) = "" Then
                free = index
                Exit For
            Else
                free = 0
            End If
        Next

        rightcheck = False
        leftcheck = False
    End Sub

    Sub BinaryTreeSearch(ByVal searchItem As String)
        'Variables to be used
        Dim found As Boolean = False
        Dim current As String = ""
        'Check if binary tree exists
        If root = 0 Then
            WriteLine("Empty binary tree!")
        Else
            'Use current pointer to go to each node,initially start at root
            current = root
            'Continually look for item unless there is no more nodes or has found item
            While current <> "Null" And found = False
                'Change boolean value to true if found.
                If data(current) = searchItem Then
                    found = True
                Else
                    'Go left if item is less than node's value, otherwise right.
                    If searchItem < data(current) Then
                        current = left(current)
                    Else
                        current = right(current)
                    End If
                End If
            End While

        End If
        'Inform user if index of item if found, otherwise indicate item not found.
        If found = True Then
            WriteLine("Binary item found at: " & current)
        Else
            WriteLine("Binary item not found!")
        End If
    End Sub

    Sub BinaryTreeDeletion(ByVal DelItem As String)
        Dim found As Boolean = False
        Dim current As String = ""
        Dim previous As String = ""
        Dim leftcheck As Boolean = False
        Dim rightcheck As Boolean = False
        If root = 0 Then
            WriteLine("THere is no bianry tree!")
        Else
            current = root
            While current <> "Null" And found = False
                If data(current) = DelItem Then
                    found = True
                Else
                    'Previous keeps track of subtree root node for insertion before current changes to null.
                    previous = current
                    If DelItem < data(current) Then
                        current = left(current)
                        leftcheck = True
                    Else
                        current = right(current)
                        rightcheck = True
                    End If
                End If
            End While
        End If

        If found = True Then
            WriteLine("Item at current: " & data(current))
            'Case 1: Node is to be a leaf node.
            If left(current) = "Null" And right(current) = "Null" Then
                'Set node's data to empty string to show deletion.
                data(current) = ""
            End If
            'Case 2: Node to be deleted has one child. If child of current node is at right.
            If left(current) = "Null" And right(current) <> "Null" Then
                'if current node is at left of parent node.
                If leftcheck = True Then
                    'set left of parent node to child node.
                    left(previous) = right(current)
                Else
                    'Set right of parent node to child node.
                    right(previous) = right(current)
                End If
                'Reset deleted node data, left and right
                data(current) = ""
                left(current) = "Null"
                right(current) = "Null"
            End If

            'If child of current node is at left.
            If right(current) = "Null" And left(current) <> "Null" Then
                'If current node is at left of parent node.
                If leftcheck = True Then
                    'set left of parent node to child node.
                    right(previous) = left(current)

                End If
                'Reset deleted node data, left and right.
                data(current) = ""
                left(current) = "Null"
                right(current) = "Null"
            End If
            'Case 3: Deleted node ahs 2 children.
            If left(current) <> "Null" And right(current) <> "Null" Then
                'Required for A level!!
            End If
            WriteLine("Item has been deleted.")
        Else
            WriteLine("Item to be deletd has not been found.")
        End If
    End Sub

    'Binary Tree Taversal.
    'Traversal is best done recursively.
    'Three depth first strategies:
    '1. Pre-Order.
    '2. Post-Order.
    '3. In-Order.

    '1.Pre-Order Traversal.
    'First visit the root,
    'then traverse the subtree
    'Then Traverse the right subtree.
    Sub Pre_OrderTraversal(currentPointer)
        WriteLine(data(currentPointer))
        If left(currentPointer) <> 0 Then
            Call Pre_OrderTraversal(left(currentPointer))

        End If
        If right(currentPointer) <> 0 Then
            Call Pre_OrderTraversal(right(currentPointer))
        End If
    End Sub

    '2.Post-Order Traversal.
    'First traverse left subtree
    'Then traverse right subtree.
    'Then visit the root.
    'This is a bottom up traversal.
    'We Visit the leaves before encountering all of the roots
    Sub Post_OrderTraversal(currentPointer)
        If left(currentPointer) <> 0 Then
            Post_OrderTraversal(left(currentPointer))
        End If

        If right(currentPointer) <> 0 Then
            Post_OrderTraversal(right(currentPointer))
        End If
        WriteLine(data(currentPointer))
    End Sub

    '3.In-Order traversal.
    'Traverse left subtree.
    'Then visit the root.
    'Then traverse the right subtree

    Sub In_OrderTraversal(currentPointer)
        If left(currentPointer) <> 0 Then
            Call In_OrderTraversal(left(currentPointer))

        End If
        WriteLine(data(currentPointer))
        If right(currentPointer) <> 0 Then
            Call In_OrderTraversal(right(currentPointer))
        End If
    End Sub
    Sub BinaryTreeMenu()
        Dim InsertItem As String
        Dim SearchItem As String
        Dim DeleteItem As String
        Dim Count = 0
        BinaryTreeInitialisation()
        Do
            WriteLine("Please enter item to insert into binary tree: ")
            InsertItem = ReadLine()
            BinaryTreeInsertion(InsertItem)
            Count = Count + 1
            Clear()

        Loop Until Count = 4
        WriteLine("Here is a pre-order traversal")
        Call Pre_OrderTraversal(1)

        WriteLine("Here is a post-Order traversal: ")
        Call Post_OrderTraversal(1)

        WriteLine("Here Is an in-order traversal:  ")
        Call In_OrderTraversal(1)

        WriteLine("Please enter item to search for in binary tree: ")
        SearchItem = ReadLine()
        BinaryTreeSearch(SearchItem)

        WriteLine("Please enter item to delete from binary tree: ")
        DeleteItem = ReadLine()
        BinaryTreeDeletion(DeleteItem)
        ReadKey()
    End Sub


    'Linked Lists
    'A User-Defined record type should first be created to represent..
    '..a node's data and pointer:
    Structure ListNode
        Dim Name As String
        Dim Pointer As Integer
    End Structure
    'Define the array with the user-defines record type as its data type and also define pointers as variables
    Dim PersonList(4) As ListNode
    Dim Headpointer, freepointer As Integer
    Dim nextFreeNodeAddress As Integer
    Dim currentPointer, PreviousPointer As Integer

    'Algorithm for setting values of pointers in free list and empty data linked list:

    Sub CreateLinkedList()
        'Create free list:
        For index = 1 To 3
            PersonList(index).Pointer = index + 1
        Next
        'Last node points in free list points to value 0 (Null value)
        PersonList(4).Pointer = 0
        'Free Pointer points to the address of the first free node in the free list:
        freepointer = 1
        'HeadPointer points to value = for an empty data linked list:
        Headpointer = 0
    End Sub

    'Code for insertion in linked list
    Sub AddItem(ByVal newItem As String)
        '#1. Place item at first free node of free list if free space available.
        If freepointer <> 0 Then
            PersonList(freepointer).Name = newItem
            'Keep track of next free node in free list.
            nextFreeNodeAddress = PersonList(freepointer).Pointer
            '#2. Search data linked list to locate where to lace the new item in:
            currentPointer = Headpointer 'Use this pointer variable to go through each node
            While PersonList(currentPointer).Name < newItem And currentPointer <> 0
                PreviousPointer = currentPointer
                currentPointer = PersonList(currentPointer).Pointer
            End While

            '#3. If new item is to be placed at start of data linked list(With no nodes or existing nodes)
            '-First node of free list points to header pointer in data linked list.
            'Header pointer points to first node in free list.
            'If node to be inserted at start of linked list with or without nodes.
            If currentPointer = Headpointer Then
                PersonList(freepointer).Pointer = Headpointer
                Headpointer = freepointer
            Else
                '#4. If new item is to be placed between existing nodes or after all nodes in data linked list.
                '-if node to be inserted between existging or after all nodes in data linked list.
                PersonList(freepointer).Pointer = currentPointer
                'Note: Can also use PersonList(previousList).Pointer instead of currentPointer.
                PersonList(PreviousPointer).Pointer = freepointer
            End If

            'Free pointer points to next free node's address.
            freepointer = nextFreeNodeAddress 'Set freepointer to point to new free node.
        Else
            WriteLine("There is no free space!")
        End If
    End Sub

    Sub RemoveItem(ByVal NewItem As String)
        Dim found As Boolean = False
        currentPointer = Headpointer
        If PersonList(currentPointer).Name = NewItem Then
            Headpointer = PersonList(currentPointer).Pointer
            PersonList(currentPointer).Pointer = freepointer
            freepointer = currentPointer
            found = True
        Else
            While currentPointer <> 0 And found = False
                PreviousPointer = currentPointer
                currentPointer = PersonList(currentPointer).Pointer 'Go to next node
                If PersonList(currentPointer).Name = NewItem Then 'If there is a match.
                    PersonList(PreviousPointer).Pointer = PersonList(currentPointer).Pointer
                    PersonList(currentPointer).Pointer = freepointer
                    freepointer = currentPointer
                    found = True 'Item was found and delected.
                End If
            End While
        End If
        If found = False Then
            WriteLine("Item to be deleted not found in linked list!")
        End If
    End Sub

    Sub SearchItem(ByVal newItem As String)
        Dim found As Boolean = False
        currentPointer = Headpointer 'Use currentpoint to go through each node.
        While currentPointer <> 0 And found = False 'till end of linked list
            If PersonList(currentPointer).Name = newItem Then 'If there is a match
                WriteLine(newItem & " is found at address: " & CStr(currentPointer) _
               & " and it points to the node at address: " & CStr(PersonList(currentPointer).Pointer))
                found = True

            End If
            currentPointer = PersonList(currentPointer).Pointer 'Go to next node

        End While
        If found = False Then
            WriteLine("Item not found in linked list.")
        End If
    End Sub

    Sub LinkedListMenu()
        CreateLinkedList()
        AddItem("james")
        AddItem("October")
        AddItem("June")

        Dim Choice As String = ""
        Dim ContinueL As String = ""
        Do
            WriteLine("Please enter your choice of operation: ")
            WriteLine("1: Add item into list")
            WriteLine("2: Search for item in list")
            WriteLine("3: Remove item from list")
            WriteLine("4: Display all items from list")
            Choice = ReadLine()


            Select Case Choice
                Case 1
                    Dim Item As String = ""
                    WriteLine("Please enter item you would like to add from the linked list: ")
                    Item = ReadLine()
                    Call AddItem(Item)
                Case 2
                    Dim ItemSearch As String = ""
                    WriteLine("Please enter item to search for from the linked list: ")
                    ItemSearch = ReadLine()
                    Call SearchItem(ItemSearch)
                Case 3
                    Dim ItemRemove As String = ""
                    WriteLine("Please enter an item to remove from the linked list: ")
                    ItemRemove = ReadLine()
                    Call RemoveItem(ItemRemove)
                Case 4
                    For count = 0 To PersonList.Length
                        WriteLine(PersonList(currentPointer).Name)
                    Next

            End Select

            WriteLine("Would you like to continue using the program?[Y/N]")

            ContinueL = ReadLine()
        Loop Until (ContinueL = "N")

        ReadKey()
    End Sub


    'Dictionaries
    'Declaring a dictionary:
    'Parameters of dictionary: Data type of key, data type of value
    Dim dictionary As New Dictionary(Of String, Integer) ' Using class dictionary

    'Insert an item in the dictionary:
    Sub InsertInDictionary(ByVal key As String, ByVal value As Integer)
        'Checks that key is not already present.
        If dictionary.ContainsKey(key) Then
            WriteLine("Key already exist!")
        Else
            dictionary.Add(key, value)
        End If

    End Sub

    'Find an item in the dictionary.
    Sub findInDictionary(ByVal key As Integer)
        If dictionary(key) Then 'Can use dictionary.containskey("tom") as well
            WriteLine("Found and its value is: " & dictionary(key))
        Else
            WriteLine("Not found!")
        End If
    End Sub

    'Remove an item from the dictionary
    Sub removeFromDictionary(ByVal key As Integer)
        dictionary.Remove(key)
    End Sub

    'Print a specific item in the dictionary
    Sub printValueInDictionary(ByVal key As Integer)
        WriteLine(dictionary(key))
    End Sub

    'Print number of entries in dictionary
    Sub printNoOfEntriesInDictionary()
        WriteLine(dictionary.Count)
    End Sub

    'Print all keys and values in dictionary.
    Sub printDictionary()
        Dim pair As KeyValuePair(Of String, Integer)
        'Loop over entries.
        For Each pair In dictionary
            'Display Key and Value.
            WriteLine("{0}, {1}", pair.Key, pair.Value)
        Next
    End Sub

    Sub DictionaryMenu()
        Dim Choice As String = 0
        Dim key As String = ""
        Dim value As Integer = 0
        Dim SearchValue As String = ""
        Dim RemoveKey As String = ""
        Dim DisplayKey As String = ""
        Dim ContinueD As String = ""
        WriteLine("Welcome to the dictionary program, please select one of the options below: ")
        WriteLine("1: Insert into dictionary. ")
        WriteLine("2: Find an item in dictionary. ")
        WriteLine("3: Remove an item from dictionary.")
        WriteLine("4: Print value in dictionary.")
        WriteLine("5: Print number of entries in dictionary.")
        WriteLine("6: Print all values in dictionary.")

        WriteLine("----------------------------------")
        Do
            Write("Choice: ")
            Choice = ReadLine()
            Select Case Choice
                Case "1"
                    WriteLine("Please enter the String value:")
                    key = ReadLine()
                    WriteLine("Please enter the key value: ")
                    value = ReadLine()
                    Call InsertInDictionary(key, value)
                Case "2"
                    WriteLine("Please enter the value you want to find: ")
                    SearchValue = ReadLine()
                    Call findInDictionary(SearchValue)
                Case "3"
                    WriteLine("Please input key of item you want to remove from dictionary: ")
                    RemoveKey = ReadLine()
                    Call removeFromDictionary(RemoveKey)
                Case "4"
                    WriteLine("Please input key value for the item you want to view: ")
                    DisplayKey = ReadLine()
                    Call printValueInDictionary(DisplayKey)
                Case "5"
                    WriteLine("Number of entries in dictionary: ")
                    Call printNoOfEntriesInDictionary()
                Case "6"
                    WriteLine("All values in dictionary: ")
                    Call printDictionary()

                Case Else
                    WriteLine("Invalid input, please try again or exit the program using [X/N]:")

            End Select
        Loop Until (ContinueD = "X" Or ContinueD = "x" Or ContinueD = "N" Or ContinueD = "n")
        WriteLine("Thank you for using this part of the program!")
    End Sub

    'Searching algorithms.................
    'Serial Searching:
    Dim ArrayData() As Integer = {2, 3, 6, 3, 4, 2, 7, 6, 324}
    Sub SerialSearch(ByVal SearchItem As Integer)
        Dim found As Boolean = False
        Dim index As Integer = 0
        Do While index <= ArrayData.Length - 1 And found = False
            If ArrayData(index) = SearchItem Then
                WriteLine("Found at Position: " & index)
                found = True
            Else
                index = index + 1

            End If
        Loop
        If found = False Then
            WriteLine("Item was not found")
        End If

    End Sub

    'Binary Searching. This is more efficient than a serial search as a serial search can be very slow.
    Sub BinarySearch(ByVal SearchItem As Integer)
        Dim found As Boolean = False
        Dim indexSearchItem, lowIndex, HighIndex, MiddleIndex As Integer
        lowIndex = 1
        HighIndex = ArrayData.Length() - 1
        While HighIndex >= lowIndex And found = False
            MiddleIndex = Int((lowIndex + HighIndex) / 2)
            If SearchItem = data(MiddleIndex) Then
                indexSearchItem = MiddleIndex
                found = True
            Else
                If SearchItem < data(MiddleIndex) Then
                    HighIndex = MiddleIndex - 1
                Else
                    lowIndex = MiddleIndex + 1
                End If
            End If
        End While
        If found = False Then
            WriteLine(SearchItem & " not found!")
        Else
            WriteLine(SearchItem & " is found at index: " & indexSearchItem)
        End If
    End Sub

    'Sorting Algorithms
    'insertion sort.
    Sub InsertionSort()
        Dim ArrayList() As Integer = {23, 6, 43, 865, 3454, 23, 54, 12, 87, 45, 84, 235, 212}
        Dim Temp As Integer = 0

        'Starting from second number.
        For i = 1 To ArrayList.Length() - 1
            'Compare as from previous element to 1st element in array
            For k = i - 1 To 0 Step -1
                'Each time if previous element > current element, swap
                If ArrayList(k) > ArrayList(k + 1) Then
                    Temp = ArrayList(k + 1) 'Temporarily store element
                    ArrayList(k + 1) = ArrayList(k) 'Swap
                    ArrayList(k) = Temp
                End If
            Next
        Next

        'Displaying output: 
        For k = 0 To ArrayList.Length() - 1
            Write(ArrayList(k))
            Write(" ")
        Next
    End Sub

    'File Handling and processing.
    'Define a structure/record type that corresponds to....
    'the records the file contains or will contain.

    Structure EmployeeRecord
        Dim ID As Integer ' integer is 2 byte.
        Dim MonthlySalary As Double
        'All records in a random-access file mus thav ethe same length.
        'Declare a fixed-lenth string using VBFixedString attribute.
        <VBFixedString(15)> Dim FirstName As String
        <VBFixedString(15)> Dim LastName As String
        <VBFixedString(20)> Dim Title As String
    End Structure
    'Declare variables to process a file opened for random access.
    Dim Employee As EmployeeRecord ' Declare a record variable.
    Dim FileNumber As Integer
    Dim LastRec As Integer
    Dim Position As Integer 'Track the current record.
    Dim recLength As Long = Len(Employee) 'Calculate the record length

    'Find last record number of the random file

    Function RandomGetLastRecord() As Integer
        FileNumber = FreeFile()
        'Open the new file with the FileOpen Statement
        FileOpen(FileNumber, "C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt", OpenMode.Random,
                    OpenAccess.ReadWrite,, recLength)
        Dim LastRecord As Long
        LastRecord = 1
        'EOF() function is using to detect the end of file.
        Do While Not EOF(FileNumber)
            'FileGet() function is used to get a record from random file.
            FileGet(FileNumber, Employee, LastRecord)
            LastRecord = LastRecord + 1

        Loop
        'Close the file.
        FileClose(FileNumber)
        Return LastRecord
    End Function

    'Input records in a random file.
    Sub RandomInputIntoFile()
        Dim answer As Char = "y"
        Dim EmployeeID As Integer
        Dim EmployeeMonthlySalary As Double
        Dim EmployeeFirstName As String = ""
        Dim EmployeeLastName As String = ""
        Dim EmployeeTitle As String = ""
        Do While answer = "y" Or answer = "Y"
            'Find the last record of random file.
            LastRec = RandomGetLastRecord()
            'get the available file number.
            '(Generate new file number for each new operation).
            FileNumber = FreeFile()
            FileOpen(FileNumber, "C:\Users\rossb\Desktop\Upper 6A-Lower 6A\Computer Science\Programs\ALJune\Edit.txt", OpenMode.Random, ,  , recLength)

            WriteLine("Please enter employee ID: ")
            EmployeeID = ReadLine()
            Employee.ID = EmployeeID

            WriteLine("Please enter employee's monthly salary: ")
            EmployeeMonthlySalary = ReadLine()
            Employee.MonthlySalary = EmployeeMonthlySalary

            WriteLine("Please enter employee's first name: ")
            EmployeeFirstName = ReadLine()
            Employee.FirstName = EmployeeFirstName

            WriteLine("Please enter employee's last name: ")
            EmployeeLastName = ReadLine()
            Employee.LastName = EmployeeLastName

            WriteLine("Please enter employee's title: ")
            EmployeeTitle = ReadLine()
            Employee.Title = EmployeeTitle

            'Put the mployee record into the random file as last record.
            FilePut(FileNumber, Employee, LastRec)

            FileClose(FileNumber)
            WriteLine("More records [Y/N]?")
            answer = ReadLine()
        Loop
    End Sub

    'Read all records form a random file.
    Sub RandomGetFromFile()
        FileNumber = FreeFile()
        'Open the new file with the FIleOpen statement. Creates file if not present.

        FileOpen(FileNumber, "C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt", OpenMode.Random, ,  , recLength)
        Position = 1 'Start with 1st record.
        Do While Not (EOF(FileNumber))
            FileGet(FileNumber, Employee, Position)
            WriteLine(CStr(Employee.ID) & "-" & Employee.FirstName _
                & "-" & Employee.LastName)
            Position = Position + 1
        Loop
        FileClose(FileNumber)
    End Sub

    'Search a specific record in a random file.
    Sub RandomSearchRecord(ByVal id As Integer)
        'get the next available file number.
        FileNumber = FreeFile()
        Dim found As Boolean = False
        'Open the new file with the FileOpen Statement.

        FileOpen(FileNumber, "C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt", OpenMode.Random, ,  , recLength)
        Do While Not EOF(FileNumber) And found = False
            FileGet(FileNumber, Employee,)
            If Employee.ID = id Then
                'Keep the current position of record.
                'In "Position" variable to use on further use such as update or delete operations.
                Position = Loc(FileNumber)
                found = True
            End If
        Loop
        WriteLine("Record found at position: " & Position)
        'Note: With random files, the LOC function returns the current record number.
        'For example, the following line outputs end of file if the current...
        '...record number in file #1 is higher than 99.
    End Sub

    'Update a specific record in a random file.
    Sub RandomUpdateRecord(ByVal id As Integer)
        RandomSearchRecord(id)
        FileNumber = FreeFile()
        'Open the new file with the FileOpen statement. Creates file if not present

        FileOpen(FileNumber, "C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt", OpenMode.Random, ,  , recLength)
        'Seek() function is used to move the pointer to any position of random file.
        Seek(FileNumber, Position)
        Employee.LastName = "Alexi"
        FilePut(FileNumber, Employee, )
        FileClose(FileNumber)
    End Sub

    'Delete a specific record in a random file.
    Sub RandomDeleteRecord(ByVal id As Integer)
        RandomSearchRecord(id)
        Dim FileNumber1, FileNumber2 As Integer
        FileNumber1 = FreeFile()
        'Open the new file with the FileOpen statement. Creates file if not present.

        FileOpen(FileNumber1, "C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt", OpenMode.Random, ,  , recLength)
        FileNumber2 = FreeFile()
        'This is for temporary random file.
        FileOpen(FileNumber2, "C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt", OpenMode.Random, ,  , recLength)

        Do While Not EOF(FileNumber1)

            'We used "Positon-1" because we do not want to copy the record,
            'which its record positon is equal to Positon variable to the temporary file.
            'When the pointer comes to the previous record, we want it to read the record which its position,
            'is equal to Position variable and do not write this into temporary file(Else Statement).
            'For example, if we want to delete third record (Position = 3), when the pointer comes to the record 2.
            '(loc(FileNum1_ = Position-1 condition is valid), 
            'It will make only FileGet(). THis means that it will not wrtie the record 3 to temporary file,
            'Note that; FIleGet() function reads record 3 when the pointe is on record 2.
            If (Loc(FileNumber1) <> Position - 1) Then
                FileGet(FileNumber1, Employee, )
                FilePut(FileNumber2, Employee, )
            Else
                FileGet(FileNumber1, Employee, )

            End If

        Loop
        FileClose(FileNumber1)
        FileClose(FileNumber2)
        'Delete the random file.
        Kill("C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt")
        'Rename the temporary file by giving the same name as deleted random file.
        Rename("C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/EditNew.txt", "C:/Users/rossb/Desktop/Upper 6A-Lower 6A/Computer Science/Programs/ALJune/Edit.txt")

    End Sub

    Sub FileHandlingMenu()
        Dim Choice As Integer = 0
        Dim ContinueF As String = ""
        Dim Sid, Uid, Did As String

        WriteLine("Coded By Alexi kehayias...")
        WriteLine("Welcome to the file handling section of the program, please select an operation below: ")
        WriteLine("1: Input employee information.")
        WriteLine("2: Search from file.")
        WriteLine("3: Update a record from the file.")
        WriteLine("4: Delete a record from the file.")
        Do


            Choice = ReadLine()
            Select Case Choice
                Case 1
                    Call RandomInputIntoFile()

                Case 2
                    WriteLine("Please enter the id of the record which you would like to search for: ")
                    Sid = ReadLine()
                    Call RandomSearchRecord(Sid)
                Case 3
                    WriteLine("Please enter the id of the record which you would like to update: ")
                    Uid = ReadLine()
                    Call RandomUpdateRecord(Uid)
                Case 4
                    WriteLine("Please enter the id of the record which you would like to delete: ")
                    Did = ReadLine()
                    Call RandomDeleteRecord(Did)
                Case Else
                    WriteLine("Invalid information, please try again.")
            End Select
            WriteLine("Do you want to continue using the program? [Decisions from menu/N]")
            ContinueF = ReadLine()

        Loop Until (ContinueF = "N" Or ContinueF = "n")
    End Sub

    Sub LittleCode()
        Dim mark As Integer = 0
        Dim Counter As Integer = 0
        While (Counter < 5)
            WriteLine("Please enter your mark: ")
            mark = ReadLine()
            Select Case mark

                Case 90 To 100
                    WriteLine("A*")
                Case 80 To 89
                    WriteLine("A")
                Case 70 To 79
                    WriteLine("B")
                Case 60 To 69
                    WriteLine("C")
                Case 50 To 59
                    WriteLine("D")
                Case 40 To 49
                    WriteLine("E")
                Case 0 To 39
                    WriteLine("U")
                Case Else
                    WriteLine("Invalid mark! ")
            End Select
            Counter = Counter + 1
            ReadKey()
        End While
    End Sub

    'This is the main menu of the program.
    Sub MainMenu()
        Dim Decision As Integer = 0
        Dim ContinueM As String = ""
        Dim SerialValue As Integer = 0
        Dim BinaryValue As Integer = 0

        WriteLine("Welcome to the main program, here is a list of choices you can choose from: ")
        WriteLine("1: Recusion.")
        WriteLine("2: Queue operations.")
        WriteLine("3: Dictonary operations.")
        WriteLine("4: Binary Tree operations.")
        WriteLine("5: Linked List operations.")
        WriteLine("6: Little Code operations.")
        WriteLine("7: Serial Search.")
        WriteLine("8: Binary Search.")
        WriteLine("9: Insertion Sort")
        WriteLine("10: File Handling.")
        WriteLine("11: Classes")
        Do
            Decision = ReadLine()
            Select Case Decision
                Case 1
                    Call RecursiveFunctions()
                Case 2
                    Call QueueMenu()
                Case 3
                    Call DictionaryMenu()
                Case 4
                    Call BinaryTreeMenu()
                Case 5
                    Call LinkedListMenu()
                Case 6
                    Call LittleCode()
                Case 7
                    WriteLine("Please enter an item you would like to search for: ")
                    SerialValue = ReadLine()
                    Call SerialSearch(SerialValue)
                Case 8
                    WriteLine("Please enter an item you would like to search for: ")
                    BinaryValue = ReadLine()
                    Call BinarySearch(BinaryValue)
                Case 9
                    Call InsertionSort()
                Case 10
                    Call FileHandlingMenu()
                Case 11
                    Call ClassMenu()

                Case Else
                    WriteLine("Invalid input, please try again!")
            End Select
            WriteLine("Do you want to continue using the program? [Y/N]")
            ContinueM = ReadLine()
        Loop Until ContinueM = "N" Or ContinueM = "n"
        WriteLine("Thank you for using the program!")
        ReadKey()
    End Sub

    Sub Main()
        Call MainMenu()


    End Sub


End Module






















