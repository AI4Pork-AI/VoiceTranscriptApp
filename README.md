# Summary
Application written in C# (Frontend), that uses the C++ version of the Whisper Neural Network to transcribe audio.

# Remarks
- Load using Visual Studio
- The debug or release versions need to have the following structure
  - dll folder with:
    - ffmpeg.exe file (the audio converter)
    - main.exe (the whisper compiled version)
    - SDL2.dll
    - whisper.dll
  - models folder. This folder is where the whisper models need to be stored. The avaliable models are:
    - ggml-tiny.bin
    - ggml-tiny.en.bin
    - ggml-base.bin
    - ggml-base.en.bin
    - ggml-small.bin
    - ggml-small.en.bin
    - ggml-medium.bin
    - ggml-medium.en.bin
    - ggml-large.bin
    - ggml-large.en.bin
  - AITranscriptor.exe (the compiled version of the program)
    
