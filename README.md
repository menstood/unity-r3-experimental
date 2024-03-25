# Unity Clock with R3

This Unity project demonstrates the use of R3, a reactive programming framework for .NET, to update clock views for different time zones.

## Description

The `Clock` class initializes three different `ClockView` components, each representing a clock for a specific time zone: Thailand (TH), South Africa (ZA), and the United Kingdom (UK). Each clock view subscribes to a `CurrentTime` observable from the `ClockViewModel` and displays the time accordingly.

## Components

### Clock

The main script attached to the Unity GameObject that initializes the clock views.

### ClockViewModel

A model holding the reactive property for the current time, which ticks every second.

### ClockView

A view component that takes an observable of `TimeSpan` and updates the UI text element with the formatted time string.

## Usage

1. Attach the `Clock` script to a GameObject in your Unity scene.
2. Assign the `clockViewTH`, `clockViewZA`, and `clockViewUK` serialized fields with instances of `ClockView`.
3. Run the scene, and you will see each clock ticking in real-time according to its time zone.

## Installation

To use this project, you need to have the R3 library installed and configured in your Unity project.

1. Clone this repository.
2. Open the project in Unity.
3. Ensure you have R3 available in the project.
4. Play the scene.

## Notes

- This project uses R3 for reactive programming. Make sure you understand how R3 works for effective modifications.
- Time zones are hardcoded for demonstration purposes. For a production application, consider a more robust time zone management approach.

---

Feel free to explore the code and integrate it into your own projects. For more information on R3 and how to use it in Unity, check out [R3's GitHub repository](https://github.com/Cy
