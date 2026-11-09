# LLM Project

An LLM lab for my HCI course: a chatty villager from a fantasy town, powered by a small language model that runs locally in Unity with [LLMUnity](https://github.com/undreamai/LLMUnity).

The full walkthrough is in the blog post [LLM-Based Character in Unity](https://attaul.com/en/blog/human-computer-interaction/week-5/llm-based-character-in-unity).

![The Unity editor in Play mode, with a chat window where the villager, Silas, says he sells vegetables, mainly tomatoes and onions](docs/chat.png)

## Requirements

- [Unity 6.5](https://unity.com/download) (6000.5.2f1)
- [LLMUnity 3.0](https://github.com/undreamai/LLMUnity) (installed from its Git URL, already listed in `Packages/manifest.json`)

## Project Layout

```text
LLM Project
├── Assets
│   ├── Fonts/                  Inter, used for the chat text
│   ├── Scenes
│   │   └── SampleScene.unity   the LLM, the villager and the chat window
│   └── Scripts
│       └── NPCController.cs    sends messages and streams replies token by token
└── docs/                       README media
```

## Getting Started

1. Open the project in Unity Hub and open `SampleScene`.
2. The model file is not in the repository. Select `LLMGameObject` and download **Qwen 3.5 0.8B** (`Qwen3.5-0.8B-Q4_K_M.gguf`) from the model list on the _LLM_ component.
3. Press Play and type a message in the chat window.

The villager's personality is the system prompt on the _LLMAgent_ component of `AICharacter`.
