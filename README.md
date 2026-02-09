# School Management System (Console App) — C#

A simple **console-based School Management System** built in **C#** to practice **OOP concepts**, especially **Inheritance**.  
The system can create and display details for **Students**, **Teachers**, and **Staff** using a shared base class `Person`.

---

## Features

- Add **Student** (Name, ID, Age, Grade)
- Add **Teacher** (Name, ID, Age, Subject, Salary)
- Add **Staff** (Name, ID, Age, Department, Position)
- Display entered details in the console
- Menu-driven program using a `while` loop

---

## OOP Concepts Used

### ✅ Inheritance
All roles inherit from the base class:

- `Person` (Base class)
  - `Student : Person`
  - `Teacher : Person`
  - `Staff : Person`

### ✅ Code Reuse
Common properties and methods are in `Person`, such as:
- `Name`, `Id`, `Age`
- `DisplayInfo()`

---

## Project Structure

