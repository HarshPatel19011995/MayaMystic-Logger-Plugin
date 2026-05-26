<!-- HEADER -->

<div align="center">

<img src="https://raw.githubusercontent.com/HarshPatel19011995/MayaMystic-Logger/main/Documentation~/logo.png" width="90"/>

<h1>📘 MayaMystic Logger</h1>

<p>
<b>Modular and scalable logging framework for Unity</b>
</p>

</div>

<br>

<!-- BANNER -->

<p align="center">
<img src="https://raw.githubusercontent.com/HarshPatel19011995/MayaMystic-Logger/main/.github/banner.png" width="900"/>
</p>

<hr>

<h2>📑 Table of Contents</h2>

<ul>
<li><b><a href="#overview">📌 Overview</a></b></li>
<li><b><a href="#quick-start">⚡ Quick Start</a></b></li>
<li><b><a href="#key-features">✨ Key Features</a></b></li>
<li><b><a href="#architecture">🧠 Architecture</a></b></li>
<li><b><a href="#logging-workflow">🔄 Logging Workflow</a></b></li>
<li><b><a href="#core-components">⚙ Core Components</a></b></li>
<li><b><a href="#package-information">📦 Package Information</a></b></li>
<li><b><a href="#package-structure">📁 Package Structure</a></b></li>
<li><b><a href="#documentation">📚 Documentation</a></b></li>
<li><b><a href="#samples">🧪 Samples</a></b></li>
<li><b><a href="#roadmap">🗺 Roadmap</a></b></li>
<li><b><a href="#changelog">📜 Changelog</a></b></li>
<li><b><a href="#license">📄 License</a></b></li>
<li><b><a href="#author">👤 Author</a></b></li>
</ul>

<hr>

<h2 id="overview">📌 Overview</h2>

<p>
<b>MayaMystic Logger</b> is a modular and reusable runtime logging framework for Unity.
</p>

<p>
It provides scalable utilities for structured logging, category-based logging, configurable log levels, runtime debugging workflows, formatting utilities, and extensible logging pipelines.
</p>

<h3>Built-in solutions include</h3>

<ul>
<li>Structured runtime logging</li>
<li>Configurable log levels</li>
<li>Category-based logging</li>
<li>Runtime debug utilities</li>
<li>Console logging workflows</li>
<li>Log formatting utilities</li>
<li>Stack trace support</li>
<li>Extensible writer architecture</li>
</ul>

<hr>

<h2 id="quick-start">⚡ Quick Start</h2>

<details>

<summary><b>Click to expand installation steps</b></summary>

<br>

<h3>1️⃣ Install via Git</h3>

Open <b>Unity Package Manager</b>

<pre>
Window → Package Manager
</pre>

Click

<pre>
+ → Add package from Git URL
</pre>

Paste

<pre>
https://github.com/HarshPatel19011995/MayaMystic-Logger-Plugin.git#v1.0.0
</pre>

<hr>

<h3>2️⃣ Log Information</h3>

<pre>
LoggerService.LogInfo(
    LoggerCategories.SYSTEM,
    "Initialization complete.");
</pre>

<hr>

<h3>3️⃣ Log Warning</h3>

<pre>
LoggerService.LogWarning(
    LoggerCategories.NETWORK,
    "Slow network response detected.");
</pre>

<hr>

<h3>4️⃣ Log Error</h3>

<pre>
LoggerService.LogError(
    LoggerCategories.FILE_IO,
    "Failed to save runtime file.");
</pre>

</details>

<hr>

<h2 id="key-features">✨ Key Features</h2>

<table>
<tr>
<th>Feature</th>
<th>Description</th>
</tr>

<tr>
<td><b>Centralized LoggerService</b></td>
<td>Unified runtime logging system</td>
</tr>

<tr>
<td><b>Configurable Log Levels</b></td>
<td>Info, Warning, Error, Debug, Exception, Verbose</td>
</tr>

<tr>
<td><b>Category-Based Logging</b></td>
<td>Organized runtime debugging</td>
</tr>

<tr>
<td><b>Console Logging</b></td>
<td>Structured Unity console output</td>
</tr>

<tr>
<td><b>Stack Trace Support</b></td>
<td>Improved debugging visibility</td>
</tr>

<tr>
<td><b>Configurable Architecture</b></td>
<td>ScriptableObject-driven settings system</td>
</tr>

<tr>
<td><b>Extensible Writer System</b></td>
<td>Future support for file and remote logging</td>
</tr>
</table>

<hr>

<h2 id="architecture">🧠 Architecture</h2>

<details>
<summary><b>View Architecture Diagram</b></summary>

<br>

<pre>
                 ┌────────────────┐
                 │ LoggerService  │
                 └───────┬────────┘
                         │
        ┌────────────────┼────────────────┐
        ▼                ▼                ▼
┌────────────────┐ ┌───────────────┐ ┌────────────────┐
│ LoggerConfig   │ │ LogFormatter  │ │ LogWriters     │
└──────┬─────────┘ └──────┬────────┘ └──────┬─────────┘
       │                  │                 │
       └──────────────────┼─────────────────┘
                          │
                          ▼
                 ┌────────────────┐
                 │ Unity Console  │
                 └────────────────┘
</pre>

<h3>Benefits</h3>

<ul>
<li>Clean modular architecture</li>
<li>Reusable runtime logging workflows</li>
<li>Production-ready debugging foundation</li>
<li>Scalable logging pipeline</li>
</ul>

</details>

<hr>

<h2 id="logging-workflow">🔄 Logging Workflow</h2>

<details>

<summary><b>View Logging Workflow</b></summary>

<br>

<pre>
Client Code
    ↓
LoggerService
    ↓
Log Validation
    ↓
Log Formatting
    ↓
Log Writer
    ↓
Unity Console
    ↓
Result Output
</pre>

</details>

<hr>

<h2 id="core-components">⚙ Core Components</h2>

<h3>🔹 LoggerService</h3>

Responsible for centralized runtime logging operations.

<ul>
<li>Structured logging</li>
<li>Category-based logging</li>
<li>Runtime debugging</li>
<li>Error handling</li>
<li>Log routing</li>
</ul>

<pre>
LoggerService.LogInfo(...);
</pre>

<hr>

<h3>🔹 LoggerCategories</h3>

Provides centralized log category definitions.

<pre>
LoggerCategories.SYSTEM
LoggerCategories.NETWORK
LoggerCategories.FILE_IO
</pre>

<hr>

<h3>🔹 LogFormatUtility</h3>

Provides standardized runtime log formatting.

<h4>Example Output</h4>

<pre>
[2026-05-25 10:15:23] [INFO] [SYSTEM] Initialization complete.
</pre>

<hr>

<h2 id="package-information">📦 Package Information</h2>

<table>
<tr><th>Property</th><th>Value</th></tr>
<tr><td>Package Name</td><td><code>com.mayamystic.logger</code></td></tr>
<tr><td>Version</td><td><b>1.0.0</b></td></tr>
<tr><td>Minimum Unity Version</td><td>2021.3 LTS</td></tr>
<tr><td>License</td><td>Proprietary – MayaMystic</td></tr>
</table>

<hr>

<h2 id="package-structure">📁 Package Structure</h2>

<pre>
Runtime/
 ├── Core/
 ├── Config/
 ├── Interfaces/
 ├── Models/
 ├── Utilities/
 ├── Writers/
 └── Constants/

Samples~/
Documentation~/
</pre>

<hr>

<h2 id="documentation">📚 Documentation</h2>

Full documentation:

<pre>
Documentation~/
</pre>

Includes:

<ul>
<li>Getting Started</li>
<li>Logger Architecture</li>
<li>Log Categories</li>
<li>Log Levels</li>
<li>Formatting Utilities</li>
<li>Runtime Logging Workflow</li>
</ul>

<hr>

<h2 id="samples">🧪 Samples</h2>

<pre>
Samples~/Basic Usage
</pre>

Demonstrates

<ul>
<li>Structured logging</li>
<li>Runtime debugging</li>
<li>Category-based logs</li>
<li>Error handling</li>
<li>Log formatting</li>
<li>Configuration usage</li>
</ul>

<hr>

<h2 id="roadmap">🗺 Roadmap</h2>

<table>
<tr><th>Version</th><th>Planned Features</th></tr>
<tr><td>v1.1</td><td>File logging support</td></tr>
<tr><td>v1.1</td><td>Runtime log filtering</td></tr>
<tr><td>v1.2</td><td>In-game runtime log viewer</td></tr>
<tr><td>v1.2</td><td>Export logs to text file</td></tr>
<tr><td>v1.3</td><td>Colored console logging</td></tr>
<tr><td>v1.3</td><td>Async log writing</td></tr>
<tr><td>v1.4</td><td>Remote/cloud logging integration</td></tr>
<tr><td>v2.0</td><td>Advanced analytics and profiling logging</td></tr>
</table>

<hr>

<h2 id="changelog">📜 Changelog</h2>

<pre>
CHANGELOG.md
</pre>

<hr>

<h2 id="license">📄 License</h2>

<pre>
LICENSE.md
</pre>

Proprietary – MayaMystic  
All rights reserved.

<hr>

<h2 id="author">👤 Author</h2>

<b>Harsh Patel</b>  
MayaMystic

GitHub  
https://github.com/HarshPatel19011995

<hr>

<h2>⭐ Contributing</h2>

Currently maintained internally.  
External contributions may be accepted in future releases.
