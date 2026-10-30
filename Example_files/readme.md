# Chapter 4: File Handling in C# Windows Forms

## Project Description
This project demonstrates how to work with text files in C# using Windows Forms. It explains how to create, read, write, append, and delete files using the `System.IO` namespace.

## Project Objectives
- Understand file handling in C#.
- Create and manage text files.
- Read data from existing files.
- Write and append information to files.
- Delete files when they are no longer needed.

## Application Features

### 1. Create File
Creates a new text file named `index.txt` using `File.CreateText()` and `StreamWriter`.

### 2. Read File
Reads the contents of an existing text file using `StreamReader`.

### 3. Write File
Writes information into a text file using `StreamWriter`.

### 4. Read All
Reads all the contents of a text file using `File.ReadAllText()`.

### 5. Append File
Adds new information to an existing text file using `File.AppendText()`.

### 6. Delete File
Checks whether the file exists and deletes it using `File.Delete()`.

## C# Classes and Methods Used

- **StreamWriter:** Used to write information into files.
- **StreamReader:** Used to read information from files.
- **File.CreateText():** Creates a new text file.
- **File.OpenText():** Opens a text file for reading.
- **File.AppendText():** Adds information to an existing file.
- **File.ReadAllText():** Reads all text from a file.
- **File.Delete():** Deletes a file.
- **Close():** Closes the file after reading or writing.

## File Handling Processes

Every file operation involves three main processes:

1. **Open File:** Establishes a connection between the file and the program.
2. **Process File:** Reads or writes information.
3. **Close File:** Closes the connection between the file and the program.




This project provides practical experience in handling text files in C#. It demonstrates how to create, read, write, append, and delete files using Windows Forms.