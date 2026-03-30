<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Chayanon Yimyam — Portfolio</title>
<link href="https://fonts.googleapis.com/css2?family=Share+Tech+Mono&family=Syne:wght@400;700;800&family=DM+Sans:wght@300;400;500&display=swap" rel="stylesheet">
<style>
  :root {
    --bg: #090c10;
    --surface: #0f1318;
    --card: #131920;
    --border: #1e2a35;
    --accent: #00e5ff;
    --accent2: #f5a623;
    --accent3: #39ff14;
    --text: #d4e0ec;
    --muted: #5a7080;
    --mono: 'Share Tech Mono', monospace;
    --display: 'Syne', sans-serif;
    --body: 'DM Sans', sans-serif;
  }

  * { margin: 0; padding: 0; box-sizing: border-box; }

  body {
    background: var(--bg);
    color: var(--text);
    font-family: var(--body);
    overflow-x: hidden;
  }

  /* noise overlay */
  body::before {
    content: '';
    position: fixed; inset: 0;
    background-image: url("data:image/svg+xml,%3Csvg viewBox='0 0 256 256' xmlns='http://www.w3.org/2000/svg'%3E%3Cfilter id='n'%3E%3CfeTurbulence type='fractalNoise' baseFrequency='0.9' numOctaves='4' stitchTiles='stitch'/%3E%3C/filter%3E%3Crect width='100%25' height='100%25' filter='url(%23n)' opacity='0.04'/%3E%3C/svg%3E");
    pointer-events: none;
    z-index: 0;
    opacity: 0.35;
  }

  /* scanline */
  body::after {
    content: '';
    position: fixed; inset: 0;
    background: repeating-linear-gradient(0deg, transparent, transparent 2px, rgba(0,229,255,0.012) 2px, rgba(0,229,255,0.012) 4px);
    pointer-events: none;
    z-index: 0;
  }

  /* ── HERO ── */
  .hero {
    position: relative;
    min-height: 100vh;
    display: flex;
    flex-direction: column;
    justify-content: center;
    padding: 80px 8vw 60px;
    border-bottom: 1px solid var(--border);
    overflow: hidden;
    z-index: 1;
  }

  .hero-grid {
    position: absolute; inset: 0;
    background-image:
      linear-gradient(rgba(0,229,255,0.04) 1px, transparent 1px),
      linear-gradient(90deg, rgba(0,229,255,0.04) 1px, transparent 1px);
    background-size: 60px 60px;
    mask-image: radial-gradient(ellipse 70% 70% at 80% 50%, black 0%, transparent 100%);
  }

  .hero-glow {
    position: absolute;
    right: -10%;
    top: 50%;
    transform: translateY(-50%);
    width: 600px;
    height: 600px;
    background: radial-gradient(circle, rgba(0,229,255,0.08) 0%, transparent 70%);
    pointer-events: none;
  }

  .boot-label {
    font-family: var(--mono);
    font-size: 11px;
    color: var(--accent3);
    letter-spacing: 3px;
    text-transform: uppercase;
    margin-bottom: 28px;
    opacity: 0;
    animation: fadeUp 0.6s ease 0.1s forwards;
  }

  .boot-label::before { content: '> '; }

  .hero-name {
    font-family: var(--display);
    font-size: clamp(42px, 7vw, 88px);
    font-weight: 800;
    line-height: 1;
    letter-spacing: -2px;
    color: #fff;
    opacity: 0;
    animation: fadeUp 0.7s ease 0.25s forwards;
  }

  .hero-name span {
    color: var(--accent);
    text-shadow: 0 0 40px rgba(0,229,255,0.4);
  }

  .role-row {
    display: flex;
    align-items: center;
    gap: 16px;
    margin-top: 28px;
    flex-wrap: wrap;
    opacity: 0;
    animation: fadeUp 0.7s ease 0.4s forwards;
  }

  .role-tag {
    font-family: var(--mono);
    font-size: 11px;
    letter-spacing: 2px;
    text-transform: uppercase;
    padding: 6px 14px;
    border: 1px solid;
    border-radius: 2px;
  }

  .role-tag.net { border-color: var(--accent); color: var(--accent); background: rgba(0,229,255,0.07); }
  .role-tag.qa  { border-color: var(--accent2); color: var(--accent2); background: rgba(245,166,35,0.07); }
  .role-tag.mp  { border-color: var(--accent3); color: var(--accent3); background: rgba(57,255,20,0.07); }

  .hero-desc {
    margin-top: 28px;
    font-size: 15px;
    font-weight: 300;
    color: var(--muted);
    max-width: 480px;
    line-height: 1.7;
    opacity: 0;
    animation: fadeUp 0.7s ease 0.55s forwards;
  }

  .hero-links {
    display: flex;
    gap: 12px;
    margin-top: 40px;
    flex-wrap: wrap;
    opacity: 0;
    animation: fadeUp 0.7s ease 0.7s forwards;
  }

  .hero-link {
    font-family: var(--mono);
    font-size: 12px;
    text-decoration: none;
    color: var(--text);
    padding: 10px 22px;
    border: 1px solid var(--border);
    border-radius: 2px;
    transition: all 0.2s;
    letter-spacing: 1px;
  }

  .hero-link:hover {
    border-color: var(--accent);
    color: var(--accent);
    background: rgba(0,229,255,0.05);
  }

  .hero-link.primary {
    background: var(--accent);
    color: #000;
    border-color: var(--accent);
    font-weight: 600;
  }

  .hero-link.primary:hover {
    background: transparent;
    color: var(--accent);
  }

  /* ── STACK TICKER ── */
  .ticker-bar {
    position: relative;
    z-index: 1;
    border-bottom: 1px solid var(--border);
    overflow: hidden;
    height: 44px;
    display: flex;
    align-items: center;
    background: var(--surface);
  }

  .ticker-label {
    font-family: var(--mono);
    font-size: 10px;
    color: var(--accent);
    letter-spacing: 2px;
    padding: 0 20px;
    border-right: 1px solid var(--border);
    white-space: nowrap;
    height: 100%;
    display: flex;
    align-items: center;
    background: var(--surface);
    z-index: 2;
    flex-shrink: 0;
  }

  .ticker-track {
    display: flex;
    animation: ticker 20s linear infinite;
    gap: 0;
  }

  .ticker-item {
    font-family: var(--mono);
    font-size: 11px;
    color: var(--muted);
    padding: 0 28px;
    white-space: nowrap;
    border-right: 1px solid var(--border);
    height: 44px;
    display: flex;
    align-items: center;
    gap: 8px;
  }

  .ticker-item em {
    color: var(--accent);
    font-style: normal;
  }

  /* ── SECTION ── */
  .section {
    position: relative;
    z-index: 1;
    padding: 80px 8vw;
  }

  .section-header {
    display: flex;
    align-items: baseline;
    gap: 16px;
    margin-bottom: 52px;
  }

  .section-num {
    font-family: var(--mono);
    font-size: 11px;
    color: var(--accent);
    letter-spacing: 2px;
  }

  .section-title {
    font-family: var(--display);
    font-size: clamp(28px, 4vw, 46px);
    font-weight: 800;
    letter-spacing: -1px;
    color: #fff;
  }

  .section-line {
    flex: 1;
    height: 1px;
    background: var(--border);
    margin-left: 12px;
  }

  /* ── GAME CARDS ── */
  .games-grid {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(340px, 1fr));
    gap: 1px;
    background: var(--border);
    border: 1px solid var(--border);
  }

  .game-card {
    background: var(--card);
    padding: 36px 32px;
    transition: background 0.2s;
    position: relative;
    overflow: hidden;
  }

  .game-card:hover { background: #161e28; }

  .game-card::before {
    content: '';
    position: absolute;
    top: 0; left: 0;
    width: 3px; height: 100%;
    background: var(--card-accent, var(--accent));
    transition: width 0.3s ease;
  }

  .game-card:hover::before { width: 5px; }

  .card-year {
    font-family: var(--mono);
    font-size: 10px;
    color: var(--muted);
    letter-spacing: 2px;
    margin-bottom: 12px;
  }

  .card-title {
    font-family: var(--display);
    font-size: 22px;
    font-weight: 700;
    color: #fff;
    margin-bottom: 8px;
    letter-spacing: -0.5px;
  }

  .card-subtitle {
    font-size: 13px;
    color: var(--muted);
    line-height: 1.6;
    margin-bottom: 20px;
  }

  .card-tags {
    display: flex;
    flex-wrap: wrap;
    gap: 6px;
    margin-bottom: 24px;
  }

  .card-tag {
    font-family: var(--mono);
    font-size: 10px;
    color: var(--muted);
    border: 1px solid var(--border);
    padding: 3px 9px;
    border-radius: 2px;
    letter-spacing: 1px;
  }

  .card-tag.hl {
    color: var(--card-accent, var(--accent));
    border-color: var(--card-accent, var(--accent));
  }

  .card-highlights {
    list-style: none;
    margin-bottom: 24px;
  }

  .card-highlights li {
    font-size: 13px;
    color: var(--muted);
    padding: 5px 0;
    padding-left: 16px;
    position: relative;
    line-height: 1.5;
  }

  .card-highlights li::before {
    content: '▸';
    position: absolute;
    left: 0;
    color: var(--card-accent, var(--accent));
    font-size: 10px;
    top: 6px;
  }

  .card-links {
    display: flex;
    gap: 10px;
    flex-wrap: wrap;
  }

  .card-link {
    font-family: var(--mono);
    font-size: 10px;
    letter-spacing: 1px;
    text-decoration: none;
    padding: 6px 14px;
    border: 1px solid var(--border);
    color: var(--muted);
    transition: all 0.2s;
    border-radius: 2px;
  }

  .card-link:hover {
    color: var(--card-accent, var(--accent));
    border-color: var(--card-accent, var(--accent));
  }

  /* ── SKILLS HUD ── */
  .hud-grid {
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(260px, 1fr));
    gap: 1px;
    background: var(--border);
    border: 1px solid var(--border);
  }

  .hud-block {
    background: var(--card);
    padding: 28px 28px;
  }

  .hud-label {
    font-family: var(--mono);
    font-size: 10px;
    color: var(--accent);
    letter-spacing: 3px;
    text-transform: uppercase;
    margin-bottom: 16px;
    display: flex;
    align-items: center;
    gap: 8px;
  }

  .hud-label::after {
    content: '';
    flex: 1;
    height: 1px;
    background: var(--border);
  }

  .skill-list {
    list-style: none;
    display: flex;
    flex-direction: column;
    gap: 10px;
  }

  .skill-item {
    display: flex;
    align-items: center;
    justify-content: space-between;
    gap: 12px;
  }

  .skill-name {
    font-size: 13px;
    color: var(--text);
    white-space: nowrap;
  }

  .skill-bar {
    flex: 1;
    height: 3px;
    background: var(--border);
    border-radius: 2px;
    overflow: hidden;
  }

  .skill-fill {
    height: 100%;
    background: var(--accent);
    border-radius: 2px;
    transition: width 1s ease;
  }

  /* QA special color */
  .hud-block.qa-block .hud-label { color: var(--accent2); }
  .hud-block.qa-block .skill-fill { background: var(--accent2); }
  .hud-block.qa-block .hud-label::after { background: var(--border); }

  /* ── EXPERIENCE TIMELINE ── */
  .timeline {
    position: relative;
    padding-left: 28px;
  }

  .timeline::before {
    content: '';
    position: absolute;
    left: 0; top: 8px; bottom: 8px;
    width: 1px;
    background: var(--border);
  }

  .timeline-item {
    position: relative;
    margin-bottom: 40px;
  }

  .timeline-item::before {
    content: '';
    position: absolute;
    left: -32px; top: 7px;
    width: 9px; height: 9px;
    border: 1px solid var(--accent);
    background: var(--bg);
    border-radius: 50%;
  }

  .timeline-meta {
    font-family: var(--mono);
    font-size: 10px;
    color: var(--accent);
    letter-spacing: 2px;
    margin-bottom: 6px;
  }

  .timeline-title {
    font-family: var(--display);
    font-size: 18px;
    font-weight: 700;
    color: #fff;
    margin-bottom: 4px;
  }

  .timeline-sub {
    font-size: 13px;
    color: var(--muted);
    margin-bottom: 10px;
  }

  .timeline-desc {
    font-size: 13px;
    color: var(--muted);
    line-height: 1.7;
  }

  /* ── FOOTER ── */
  .footer {
    position: relative;
    z-index: 1;
    border-top: 1px solid var(--border);
    padding: 40px 8vw;
    display: flex;
    align-items: center;
    justify-content: space-between;
    flex-wrap: gap;
    gap: 20px;
  }

  .footer-id {
    font-family: var(--mono);
    font-size: 11px;
    color: var(--muted);
    letter-spacing: 2px;
  }

  .footer-contact {
    font-family: var(--mono);
    font-size: 11px;
    color: var(--muted);
    display: flex;
    gap: 24px;
    flex-wrap: wrap;
  }

  .footer-contact a {
    color: var(--muted);
    text-decoration: none;
    transition: color 0.2s;
  }

  .footer-contact a:hover { color: var(--accent); }

  /* ── ANIM ── */
  @keyframes fadeUp {
    from { opacity: 0; transform: translateY(16px); }
    to   { opacity: 1; transform: translateY(0); }
  }

  @keyframes ticker {
    from { transform: translateX(0); }
    to   { transform: translateX(-50%); }
  }

  /* section fade-in */
  .reveal {
    opacity: 0;
    transform: translateY(24px);
    transition: opacity 0.7s ease, transform 0.7s ease;
  }

  .reveal.visible {
    opacity: 1;
    transform: translateY(0);
  }
</style>
</head>
<body>

<!-- HERO -->
<section class="hero">
  <div class="hero-grid"></div>
  <div class="hero-glow"></div>

  <div class="boot-label">CHAYANON YIMYAM — PORTFOLIO_v2025</div>

  <h1 class="hero-name">
    Game<br><span>Developer</span>
  </h1>

  <div class="role-row">
    <span class="role-tag net">Multiplayer &amp; Networking</span>
    <span class="role-tag mp">Unity / C#</span>
    <span class="role-tag qa">QA &amp; Game Testing</span>
  </div>

  <p class="hero-desc">
    Fresh grad from Bangkok University, Games &amp; Interactive Media '26.<br>
    Specializing in server-authoritative multiplayer systems, real-time networking, and game quality assurance.
  </p>

  <div class="hero-links">
    <a class="hero-link primary" href="https://pbzpooh123.github.io" target="_blank">↗ PORTFOLIO SITE</a>
    <a class="hero-link" href="https://github.com/pbzpooh123/Chayanon_Yimyam_Port" target="_blank">GITHUB</a>
    <a class="hero-link" href="mailto:chayanon.yimyam04@gmail.com">EMAIL</a>
  </div>
</section>

<!-- TECH TICKER -->
<div class="ticker-bar">
  <div class="ticker-label">TECH STACK</div>
  <div style="overflow:hidden; flex:1;">
    <div class="ticker-track" id="ticker"></div>
  </div>
</div>

<!-- PROJECTS -->
<section class="section reveal">
  <div class="section-header">
    <span class="section-num">01</span>
    <h2 class="section-title">Projects</h2>
    <div class="section-line"></div>
  </div>

  <div class="games-grid">

    <!-- Iron Curtain -->
    <div class="game-card" style="--card-accent: #00e5ff;">
      <div class="card-year">2025 · THESIS PROJECT</div>
      <div class="card-title">🌍 Iron Curtain</div>
      <div class="card-subtitle">Cold War–themed multiplayer economic board game. 4 players, real-time networking, competitive stock market.</div>
      <div class="card-tags">
        <span class="card-tag hl">FishNet 4</span>
        <span class="card-tag hl">Server-Authoritative</span>
        <span class="card-tag">Unity 2022</span>
        <span class="card-tag">C#</span>
        <span class="card-tag">Online Multiplayer</span>
      </div>
      <ul class="card-highlights">
        <li>Real-time turn sync &amp; authoritative server logic via FishNet 4</li>
        <li>Dynamic stock ownership system with percentage stakes</li>
        <li>Proposal-based negotiation mechanic for player-to-player deals</li>
        <li>Animated end-game analytics &amp; investor title system</li>
      </ul>
      <div class="card-links">
        <a class="card-link" href="https://pbzpooh123.itch.io/iron" target="_blank">↗ ITCH.IO</a>
        <a class="card-link" href="https://youtu.be/kqVdGULhmao" target="_blank">▶ TRAILER</a>
        <a class="card-link" href="https://github.com/pbzpooh123/Ironcur" target="_blank">REPO</a>
      </div>
    </div>

    <!-- Infinite Deflect -->
    <div class="game-card" style="--card-accent: #39ff14;">
      <div class="card-year">2025 · PVP</div>
      <div class="card-title">🏓 Infinite Deflect</div>
      <div class="card-subtitle">Fast-paced 4-player online PvP. Deflect a ball or get eliminated — last player standing wins.</div>
      <div class="card-tags">
        <span class="card-tag hl">Unity Netcode</span>
        <span class="card-tag hl">PvP</span>
        <span class="card-tag">Unity 2022</span>
        <span class="card-tag">C#</span>
        <span class="card-tag">Online Multiplayer</span>
      </div>
      <ul class="card-highlights">
        <li>Random ball targeting system — unpredictable each round</li>
        <li>Networked state management with Unity Netcode for GameObjects</li>
        <li>Smooth mid-session respawn &amp; round transition logic</li>
      </ul>
      <div class="card-links">
        <a class="card-link" href="https://pbzpooh123.itch.io/infinite-deflect" target="_blank">↗ ITCH.IO</a>
        <a class="card-link" href="https://github.com/pbzpooh123/Infinite-Deflect.git" target="_blank">REPO</a>
      </div>
    </div>

    <!-- Fire Keeper -->
    <div class="game-card" style="--card-accent: #f5a623;">
      <div class="card-year">2025 · MOBILE</div>
      <div class="card-title">🔥 Fire Keeper</div>
      <div class="card-subtitle">2D side-scrolling platformer prototype — first Android game build with Celeste-style checkpoint respawn system.</div>
      <div class="card-tags">
        <span class="card-tag hl">Android</span>
        <span class="card-tag">Unity 2022</span>
        <span class="card-tag">C#</span>
        <span class="card-tag">2D Platformer</span>
      </div>
      <ul class="card-highlights">
        <li>Checkpoint-based respawn system inspired by Celeste</li>
        <li>First mobile (Android) deployment — full build pipeline</li>
      </ul>
      <div class="card-links">
        <a class="card-link" href="https://pbzpooh123.itch.io/grassland-adventures" target="_blank">↗ ITCH.IO</a>
        <a class="card-link" href="https://github.com/pbzpooh123/Mobile-Project.git" target="_blank">REPO</a>
      </div>
    </div>

    <!-- Toytopia -->
    <div class="game-card" style="--card-accent: #b06aff;">
      <div class="card-year">2023 · FIRST GAME</div>
      <div class="card-title">🧸 Toytopia Defense</div>
      <div class="card-subtitle">2D tower defense — first shipped game. Built entirely in GameMaker Studio 2.</div>
      <div class="card-tags">
        <span class="card-tag hl">GameMaker Studio 2</span>
        <span class="card-tag">GML</span>
        <span class="card-tag">Tower Defense</span>
      </div>
      <ul class="card-highlights">
        <li>Custom enemy pathfinding system</li>
        <li>Tower upgrade mechanics &amp; round system with skip button</li>
      </ul>
      <div class="card-links">
        <a class="card-link" href="https://everlasting8.itch.io/toytopia-defense" target="_blank">↗ ITCH.IO</a>
      </div>
    </div>

  </div>
</section>

<!-- SKILLS HUD -->
<section class="section reveal" style="background: var(--surface); border-top: 1px solid var(--border); border-bottom: 1px solid var(--border);">
  <div class="section-header">
    <span class="section-num">02</span>
    <h2 class="section-title">Skills</h2>
    <div class="section-line"></div>
  </div>

  <div class="hud-grid">

    <div class="hud-block">
      <div class="hud-label">Dev · Engine</div>
      <ul class="skill-list">
        <li class="skill-item">
          <span class="skill-name">Unity / C#</span>
          <div class="skill-bar"><div class="skill-fill" style="width:90%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">FishNet 4</span>
          <div class="skill-bar"><div class="skill-fill" style="width:80%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Unity Netcode (NGO)</span>
          <div class="skill-bar"><div class="skill-fill" style="width:75%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">GameMaker Studio 2</span>
          <div class="skill-bar"><div class="skill-fill" style="width:55%"></div></div>
        </li>
      </ul>
    </div>

    <div class="hud-block">
      <div class="hud-label">Dev · Code</div>
      <ul class="skill-list">
        <li class="skill-item">
          <span class="skill-name">C# (OOP / Events)</span>
          <div class="skill-bar"><div class="skill-fill" style="width:88%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Python</span>
          <div class="skill-bar"><div class="skill-fill" style="width:60%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Lua (Figura scripting)</span>
          <div class="skill-bar"><div class="skill-fill" style="width:50%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Git / GitHub</span>
          <div class="skill-bar"><div class="skill-fill" style="width:75%"></div></div>
        </li>
      </ul>
    </div>

    <div class="hud-block qa-block">
      <div class="hud-label">QA &amp; Testing</div>
      <ul class="skill-list">
        <li class="skill-item">
          <span class="skill-name">Functional Testing</span>
          <div class="skill-bar"><div class="skill-fill" style="width:85%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Multiplayer / Sync Testing</span>
          <div class="skill-bar"><div class="skill-fill" style="width:80%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Bug Reporting &amp; Docs</span>
          <div class="skill-bar"><div class="skill-fill" style="width:80%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Regression Testing</span>
          <div class="skill-bar"><div class="skill-fill" style="width:70%"></div></div>
        </li>
      </ul>
    </div>

    <div class="hud-block">
      <div class="hud-label">Multiplayer Systems</div>
      <ul class="skill-list">
        <li class="skill-item">
          <span class="skill-name">Server-Authoritative Logic</span>
          <div class="skill-bar"><div class="skill-fill" style="width:85%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Client-Server Sync</span>
          <div class="skill-bar"><div class="skill-fill" style="width:80%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">Turn-Based Networking</span>
          <div class="skill-bar"><div class="skill-fill" style="width:78%"></div></div>
        </li>
        <li class="skill-item">
          <span class="skill-name">API Integration (REST)</span>
          <div class="skill-bar"><div class="skill-fill" style="width:60%"></div></div>
        </li>
      </ul>
    </div>

  </div>
</section>

<!-- EXPERIENCE / ROLES -->
<section class="section reveal">
  <div class="section-header">
    <span class="section-num">03</span>
    <h2 class="section-title">Experience</h2>
    <div class="section-line"></div>
  </div>

  <div class="timeline">

    <div class="timeline-item">
      <div class="timeline-meta">2025 · THESIS</div>
      <div class="timeline-title">Lead Game Developer — Iron Curtain</div>
      <div class="timeline-sub">Bangkok University, Games &amp; Interactive Media</div>
      <div class="timeline-desc">Designed and built a full multiplayer economic board game end-to-end. Responsible for networking architecture (FishNet 4), server-authoritative game logic, UI systems, and production pipeline. Also performed internal QA — designing test cases for turn sync, money flow integrity, and edge-case client desync scenarios.</div>
    </div>

    <div class="timeline-item">
      <div class="timeline-meta">2025 · ROLE: QA TESTER &amp; DEVELOPER</div>
      <div class="timeline-title">Game QA — Multiplayer Systems</div>
      <div class="timeline-sub">Self-led testing across Iron Curtain &amp; Infinite Deflect</div>
      <div class="timeline-desc">Conducted structured multiplayer testing sessions: identifying race conditions in networked turn logic, edge-case desync in ball targeting, and regression testing after each code change. Documented bugs with reproducible steps, priority levels, and root cause analysis.</div>
    </div>

    <div class="timeline-item">
      <div class="timeline-meta">2025 · GAME JAM / SOLO</div>
      <div class="timeline-title">Mobile Game Developer — Fire Keeper</div>
      <div class="timeline-sub">Android prototype</div>
      <div class="timeline-desc">First Android deployment — full mobile build pipeline in Unity. Implemented Celeste-style checkpoint respawn, touch input handling, and platform-specific optimizations.</div>
    </div>

    <div class="timeline-item">
      <div class="timeline-meta">2023 · FIRST PROJECT</div>
      <div class="timeline-title">Game Developer — Toytopia Defense</div>
      <div class="timeline-sub">GameMaker Studio 2</div>
      <div class="timeline-desc">First shipped game. Built pathfinding, wave management, upgrade systems, and full game loop from scratch. Foundation of game development fundamentals.</div>
    </div>

  </div>
</section>

<!-- FOOTER -->
<footer class="footer">
  <div class="footer-id">CHAYANON_YIMYAM · BKK · 2025</div>
  <div class="footer-contact">
    <a href="mailto:chayanon.yimyam04@gmail.com">chayanon.yimyam04@gmail.com</a>
    <a href="tel:0909055757">090-905-5757</a>
    <a href="https://pbzpooh123.github.io" target="_blank">pbzpooh123.github.io</a>
  </div>
</footer>

<script>
  // Ticker
  const items = [
    ['Unity 2022', '#00e5ff'],['C#', '#00e5ff'],['FishNet 4', '#39ff14'],
    ['Unity Netcode', '#39ff14'],['Multiplayer Systems', '#00e5ff'],
    ['Server-Authoritative', '#f5a623'],['QA / Game Testing', '#f5a623'],
    ['Python', '#00e5ff'],['REST API', '#00e5ff'],['Git', '#39ff14'],
    ['GameMaker Studio 2', '#b06aff'],['Android Build', '#b06aff'],
    ['Bug Reporting', '#f5a623'],['Regression Testing', '#f5a623'],
  ];
  const t = document.getElementById('ticker');
  const html = items.map(([name, color]) =>
    `<div class="ticker-item"><em style="color:${color}">■</em>${name}</div>`
  ).join('');
  t.innerHTML = html + html; // duplicate for infinite loop

  // Scroll reveal
  const observer = new IntersectionObserver((entries) => {
    entries.forEach(e => { if (e.isIntersecting) e.target.classList.add('visible'); });
  }, { threshold: 0.1 });
  document.querySelectorAll('.reveal').forEach(el => observer.observe(el));
</script>

</body>
</html>
