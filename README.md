<p align="center">
  <img src="assets/hero.svg" width="100%" alt="GLATRIX, spelled out in selected bytes of a hex dump. Where managed code meets the metal. C# and C++. Noll Pointerville, Voiderland.">
</p>

<p align="center"><sub>Those bytes are real. Decode them for a word from the town council.</sub></p>

<br>

Most of what I build lives on the boundary between managed and native code: hosting the CLR inside other processes, reading engine metadata at runtime, hooking render calls, and moving data between C++ and C#. Lately I've been climbing the stack, writing neural nets from scratch and running LLMs on my own hardware.

<br>

<p align="center">
  <img src="assets/stack.svg" width="100%" alt="My stack drawn as a call stack. Above the managed to native transition: local LLM inference, neural nets, language tooling, services, and C# on .NET. Below it: CLR hosting and engine runtimes, process injection and IPC, and native C++ with Win32 and Direct3D 11 hooks. The full list is in the plain text section further down.">
</p>

<br>

Reading about how something works is fine. Making it work inside a process that wasn't expecting it is better.

<br>

<p align="center">
  <img src="assets/traces.svg" width="100%" alt="Three animated traces. One: host.exe loads a proxied version.dll, which starts a C++/CLI host, which brings up .NET 8 and runs managed code. Two: Present is detoured through MinHook and Kiero, draws a Dear ImGui overlay, then returns through a trampoline to the original. Three: a C++ server and a C# client share the same physical pages through a memory-mapped file.">
</p>

<br>

If I don't understand a thing, I end up rewriting it. So far that has included a programming language and a Keras-style ML framework.

<br>

<p align="center">
  <img src="assets/neural.svg" width="100%" alt="A neural network running forward and backward passes, a loss curve falling over epochs, and a top-k sampler choosing the next token with temperature 0.9 and k of 8.">
</p>

<br>

<details>
<summary><b>The same stack, as plain text</b></summary>
<br>

| Layer | Technologies |
| :-- | :-- |
| **Languages** | C#, C++, C, C++/CLI |
| **Local AI** | llama.cpp, GGUF, quantized KV cache, speculative decoding, GPU offload, Jinja chat templates |
| **Machine learning** | Backpropagation, Dense, Conv2D, SimpleRNN, Dropout, SGD, genetic training, word embeddings, temperature and top-k sampling |
| **Language tooling** | Lexers, parsers, ASTs, tree-walking interpreters |
| **Services** | REST SDKs, SignalR, HttpListener, JSON models, NuGet packaging |
| **.NET** | .NET 8, .NET Framework, WinForms, P/Invoke, unsafe code |
| **Runtime internals** | CLR hosting, Mono, IL2CPP, metadata APIs, internal calls, Unity |
| **Process and IPC** | DLL injection, DLL proxying, named pipes, memory-mapped files, x86 and x64 |
| **Native and graphics** | Win32, MSVC, MinHook, Kiero, Direct3D 11, DXGI, Dear ImGui |

</details>

<br>

<p align="center">Find me on Discord: <code>glatrix</code></p>

<p align="center">
  <img src="assets/void.svg" width="100%" alt="Bytes spiralling into address 0x00000000. End of mapped memory. Reading past this line is undefined behavior.">
</p>
