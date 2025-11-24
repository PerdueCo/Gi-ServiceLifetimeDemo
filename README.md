# 📘 README.md — ServiceLifetimeDemo

A beginner-friendly, instructor-style walkthrough of .NET Core service lifetimes.

ServiceLifetimeDemo
Understanding Transient, Scoped, and Singleton in a simple, hands-on way

Welcome!
This project was created to give learners—whether new developers, students, or early-career engineers—a clear and practical demonstration of how .NET Core service lifetimes work.

If you’ve ever wondered:

“What’s the real difference between Transient, Scoped, and Singleton?”

“When should I actually use each one?”

“How does .NET Core decide when to create a service instance?”

This repo breaks it all down step by step, using clean code, simple examples, and an easy-to-follow structure.

---

# 🎯 Project Purpose

This project helps you demonstrate your understanding of:

.NET Core Dependency Injection (DI)

The difference between Transient, Scoped, and Singleton

How instances are created and reused

Why choosing the correct lifetime matters for performance, correctness, and scalability

It's intentionally simple—perfect for interviews, learning sessions, or teaching others.

# 🧠 High-Level Explanation (Instructor Tone)

Transient

A brand-new instance is created every time it’s requested.

Great for lightweight, stateless, and short-lived work.

Scoped

One instance is created per HTTP request.

Commonly used with database repositories, unit-of-work patterns, and request-level state.

Singleton

Only one instance is ever created—for the entire application lifetime.

Ideal for shared, long-lived resources like caching, configuration, logging, or static reference data.

In this demo, each service returns a unique GUID so you can visually see which lifetime persists and which does not.

# 🏗 Project Structure

---

/ServiceLifetimeDemo
 ├── Controllers/
 │     └── LifetimeController.cs
 ├── Services/
 │     ├── IGuidService.cs
 │     ├── TransientGuidService.cs
 │     ├── ScopedGuidService.cs
 │     └── SingletonGuidService.cs
 ├── Program.cs
 ├── README.md
 └── Dockerfile


Everything is clean, separated, and easy to follow.
