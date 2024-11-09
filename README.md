# Augmented Reality Based Chemistry Project

## Project Overview

This **Augmented Reality (AR) based Chemistry Project** allows users to interactively learn and visualize the process of creating water by combining two hydrogen (H₂) atoms and one oxygen (O₂) atom. The molecular reaction is displayed in an **AR environment**, where users can visually witness the transformation into a water molecule (H₂O). Developed using **Unity 2022.3**, this project does not rely on **AR Foundation** but instead uses **Vuforia SDK** for marker-based AR interactions, offering an immersive educational experience.

The project demonstrates an innovative approach to chemistry education by making molecular interactions tangible through augmented reality, bridging the gap between theoretical knowledge and practical visualization.

## Key Features
- **AR Marker Interaction**: Users can scan predefined AR markers to trigger the appearance of hydrogen, oxygen, and water molecules.
- **Molecular Representation**: 3D models of hydrogen (H₂) and oxygen (O₂) atoms are used to represent the molecules, which can be moved together to form a water molecule (H₂O) in AR space.
- **Real-Time AR Interaction**: Users can interact with the 3D models in real-time, positioning and combining the molecules to simulate the chemical reaction.
- **Unity 2022.3**: The project was developed using **Unity 2022.3**, ensuring compatibility with the latest Unity tools and features.
- **Vuforia SDK**: The project uses the **Vuforia SDK** to handle the marker-based AR experience, allowing easy integration with both **Android** and **iOS** devices.

## Technologies Used
- **Unity 2022.3**: The primary game engine for building and rendering the AR environment.
- **Vuforia SDK**: A powerful AR SDK that supports marker recognition and enables AR experiences without relying on **AR Foundation**.
- **C# Scripting**: Used to implement the AR behavior and interactivity within Unity.
- **3D Modeling**: Models for hydrogen, oxygen, and water molecules created and imported into Unity for visualization in AR.

## Installation Guide

### Prerequisites
- **Unity 2022.3** (or newer)
- **Vuforia SDK** (installed via Unity Package Manager)
- **Visual Studio** (or any compatible C# IDE for script editing)
- **Android** or **iOS** device for testing the AR application.

### Steps for Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/SabyTheNoob/AR-Chemistry_Molecule-Unity.git

2. **Open the project in Unity 2022.3**:
   - Launch **Unity 2022.3** and open the project folder.

3. **Import the Vuforia SDK**:
   - In Unity, navigate to the **Package Manager** (`Window > Package Manager`).
   - Search for and import the **Vuforia SDK** package.

4. **Set Up AR for Development**:
   - Ensure that the **AR camera** and **marker settings** are configured correctly for the project.
   - Make necessary adjustments in Unity's AR settings to enable AR functionality.

5. **Build and Run**:
   - Build the project for your chosen device (iOS/Android).
   - Test the project on a physical device, as AR interactions require a camera to function.

## Marker Setup

- **AR Markers**: The project uses specific **Vuforia markers** to trigger the AR interactions.
- **Marker Usage**: Print or display these markers to enable the 3D visualization of hydrogen, oxygen, and water molecules in the AR environment.

## How to Use

1. **Scan AR Markers**:
   - Launch the app and scan the predefined **AR markers** using the camera on your mobile device.

2. **Combine Molecules**:
   - Once the markers are detected, 3D models of **hydrogen (H₂)** and **oxygen (O₂)** atoms will appear in the AR space.
   - Move the molecules closer together to simulate the chemical reaction that forms water (H₂O).

3. **Interactive Experience**:
   - Users can **rotate**, **scale**, or **move** the molecules to better understand how they combine to form **H₂O**.

4. **View Water Molecule**:
   - After successfully combining the hydrogen and oxygen atoms, the water molecule (**H₂O**) will be displayed, representing the completed molecular reaction.

## Purpose and Educational Benefits

This project provides an innovative, hands-on way for students to visualize and understand basic chemistry concepts, such as molecular bonding and atomic interactions. By combining **augmented reality** with interactive learning, this project offers a more engaging educational experience that helps students comprehend the structure of molecules and the process of chemical reactions.

## Target Audience

- **Students**: Primarily aimed at **chemistry students**, particularly at the high school and undergraduate levels, to provide a more engaging and interactive way to learn about molecular chemistry.
- **Educators**: Teachers can use this project as a tool to demonstrate basic chemical reactions and atomic bonding in an interactive format.
- **AR Enthusiasts**: Ideal for anyone interested in exploring the potential of **AR** in education and science.

## Future Enhancements

- **Add More Chemical Reactions**: Expand the project by adding other chemical reactions and molecular structures that can be explored in AR.
- **Interactive Learning Mode**: Introduce a quiz or learning mode that tests the user's knowledge about the molecules and reactions.
- **Improved AR Tracking**: Enhance the AR tracking for a more seamless and accurate experience, potentially adding support for more diverse devices.
- **Multilingual Support**: Offer the project in multiple languages to reach a global audience.

## Contributing

Contributions are always welcome! You can fork the repository, make changes, and submit a pull request. Areas where you can contribute include:

- Improving the **AR interaction** and **user interface**.
- Adding new features or **chemical reactions**.
- Fixing bugs or improving **performance**.

## License

This project is licensed under the **Apache 2.0 License**. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- **Unity Technologies**: For Unity, an exceptional platform for AR and interactive content development.
- **Vuforia SDK**: For enabling the development of AR applications using marker-based recognition.
- **AR Community**: For ongoing contributions and ideas in the field of augmented reality and educational technology.
