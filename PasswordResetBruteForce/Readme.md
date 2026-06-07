# Password Reset Application Using Brute Force and Multi-Threading

## Project Overview

This project is a Windows Forms (WinForms) application developed in C# that demonstrates password recovery using brute-force techniques.

The application generates a random password, hashes it using SHA256 with a static salt, and then attempts to recover the password using both:

- Single-thread brute force
- Multi-thread brute force

The execution times of both approaches are compared to demonstrate the performance benefits of parallel processing.

---

## Features

### Password Generation
- Generates random passwords.
- Password length is randomly selected between 4 and 5 characters.
- Uses lowercase English alphabet characters.

### Password Hashing
- SHA256 hashing algorithm.
- Static salt is added before hashing.

### Single-Thread Brute Force
- Generates password combinations sequentially.
- Searches from length 1 up to length 6.
- Does not know the password length in advance.

### Multi-Thread Brute Force
- Uses Task-based parallelism.
- Utilizes CPU Cores - 1 threads.
- Multiple threads search simultaneously.
- Stops searching when password is found.

### Performance Comparison
- Measures execution time of:
  - Single-thread brute force
  - Multi-thread brute force
- Calculates speedup.

### GUI Features
- Generate Password button
- Start Attack button
- Stop button
- Progress Bar
- Elapsed Time display
- Found Password display
- Performance output display

---

## Technologies Used

- C#
- .NET WinForms
- SHA256 Cryptography
- Multithreading (Task Parallel Library)
- Visual Studio 2022
- Git & GitHub

---

## Project Structure

```text
PasswordResetBruteForce
│
├── Form1.cs
├── PasswordGenerator.cs
├── PasswordHasher.cs
├── PasswordValidator.cs
├── BruteForceGenerator.cs
├── SingleThreadBruteForce.cs
├── MultiThreadBruteForce.cs
├── PerformanceLogger.cs
└── Program.cs