using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactHealthUI : MonoBehaviour
{
    [SerializeField]
    private Slider artifactHealthSlider; // Reference to the health slider UI element

    [SerializeField]
    private Artifact artifact; // Reference to the Artifact script that contains health information

    // Start is called before the first frame update
    void Start()
    {
        artifactHealthSlider.maxValue = artifact.maxHealth; // Set the maximum value of the slider to the artifact's max health
        artifactHealthSlider.value = artifact.maxHealth; // Initialize the slider value to the current health of the artifact
    }

    // Update is called once per frame
    void Update()
    {
        artifactHealthSlider.value = artifact.health; // Continuously update the slider value to reflect the current health of the artifact
    }
}
