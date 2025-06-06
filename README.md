# 📝 Smart Notepad in VB.NET

A modern, lightweight Notepad application built using **VB.NET**, enhanced with **AI capabilities** using **Ollama** for grammar correction and chatbot assistance. Designed with usability, productivity, and smart writing tools in mind.

## 🚀 Features

### ✨ Core Functionality
- 📄 Create, open, edit, and save `.txt` files
- 🔁 **Word Wrap Toggle** for better readability
- 📊 **Status Bar** showing real-time line and column tracking
- 🕘 **Recent Files List** for quick access
- 🌗 **Dark Mode Toggle** for comfortable writing in any environment
- 💾 **Auto-Save** feature to prevent data loss

### 🤖 AI Enhancements (via Ollama API)
- ✍️ **Grammar Correction**: Highlight text and fix grammar using LLM models
- 💬 **Chatbot Support**: Get AI assistance within the Notepad for writing, idea generation, or general queries

## 🛠️ Technologies Used

- **Frontend:** VB.NET (Windows Forms)
- **AI Integration:** Ollama (LLM Inference via HTTP API)
- **Language Model:** LLaMA 3.2 (or any compatible model)


## 🔗 API Integration

Your VB.NET app sends POST requests to this endpoint:

http
POST http://localhost:8080/grammar/correct
Content-Type: application/json

{
  "model": "llama3.2",
  "prompt": "Selected text here...",
  "stream": false
}


Response:

json
{
  "response": "Corrected version of the input text."
}



## 📄 How to Run

### 💻 VB.NET Notepad

1. Open the `NotepadApp.sln` file in **Visual Studio**
2. Build and Run the solution

3. Make sure Ollama is running and available locally

## 🧠 Future Plans

* [ ] Spell check and suggestions
* [ ] Cloud sync for documents
* [ ] Plugin support for markdown, PDF export, etc.
* [ ] Enhanced LLM prompts for summarization and rewriting

## 👨‍💻 Author

**Mehul Pathak**
📍 BCA Student | Backend & AI Enthusiast
---
