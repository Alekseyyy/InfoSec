
<img width="700px" src="./banner.png" />

This is a curation of resources created by others and notes that I have taken regarding cybersecurity and related fields.

## Contents at a glance

* H*cking Resources
  * CTF & Wargames List
* Automatiion & Systems Administration
* Machine Learning
* Academic Publications
   * DFIR Publications
   * Psychoinformatics & Data Science
* Other Awesome Resources
  * Twitter/X Posts
  * Awesome Security Firms/Organizations
  * Awesome GitHubs

## H*cking Resources

<details>
   <summary>Exploit Development, Frameworks and General Software Exploitation</summary>

   * [Rhino CVE Proof-of-Concept Exploits](https://github.com/RhinoSecurityLabs/CVEs)
   * [WAF community bypasses](https://github.com/waf-bypass-maker/waf-community-bypasses)
   * [FOFA Search Engine Library](https://github.com/FofaInfo/Awesome-FOFA)
   * [nuclei templates for WordPress websites](https://github.com/topscoder/nuclei-wordfence-cve)
   * [How to hack a website with metasploit (Jitpukdebodin, n.d.)](https://dl.packetstormsecurity.net/papers/attack/hack-websites-with-metasploit.pdf)
   * [List of Exploit Development Resources](https://github.com/cranelab/exploit-development)
   * [Automatic Exploit Generation: First of its Kind (Zhu 2019)](https://claudiazhu.medium.com/automatic-exploit-generation-first-of-its-kind-991c68da0833)
   * [autoBOF: a Journey into Automation, Exploit Development, and Buffer Overflows](https://0x00sec.org/t/autobof-a-journey-into-automation-exploit-development-and-buffer-overflows/13415)
   * [Automatic Exploit Prevention Technology](https://media.kaspersky.com/en/business-security/kaspersky-automatic-exploit-prevention-whitepaper.pdf)
   * [BishopFox Top 9 Favorite Fuzzers](https://bishopfox.com/blog/top-9-fuzzers)
</details>

<details>
 <summary>OSINT, Information Gathering, and Scanning</summary>

 * [Running a quick NMAP scan to inventory my network](https://www.redhat.com/sysadmin/quick-nmap-inventory)
 * [Nmap Host Discovery: The Ultimate Guide](https://www.device42.com/blog/2023/03/29/nmap-host-discovery-the-ultimate-guide/)
 * gau: Fetch known URLs from AlienVault's Open Threat Exchange, the Wayback Machine, and Common Crawl: [https://github.com/lc/gau](https://github.com/lc/gau)
</details>

<details>
   <summary>Digital Forensics & Incident Response</summary>

   * [Ghidra Basics: Manual Shellcode Analysis and C2 Extraction](https://embee-research.ghost.io/ghidra-basics-shellcode-analysis/)
   * [InfoSec Institute: Free & open source computer forensics tools](https://resources.infosecinstitute.com/topics/digital-forensics/free-open-source-computer-forensics-tools/)
   * [Dr. Memory: the memory debugger](https://github.com/DynamoRIO/drmemory)
</details>

### Capture the Flags & Wargames

* CTF Sites: [https://ctfsites.github.io/](https://ctfsites.github.io/)

<details>
  <summary>Mobile Phone DFIR/Reversing</summary>

  * KGB Messenger: [https://github.com/tlamb96/kgb_messenger](https://github.com/tlamb96/kgb_messenger)
  * maldr0id's "Not so boring Android malware" samples: [https://maldroid.github.io/android-malware-samples/](https://maldroid.github.io/android-malware-samples/)
  * maddiestone's Android Reverse Engineering 101: [https://www.ragingrock.com/AndroidAppRE/](https://www.ragingrock.com/AndroidAppRE/)
  * OWASP's "UnCrackable Mobile Apps": [https://github.com/OWASP/owasp-mastg/tree/master/Crackmes](https://github.com/OWASP/owasp-mastg/tree/master/Crackmes)
  * CyberTruck Challenge 19: [https://github.com/nowsecure/cybertruckchallenge19](https://github.com/nowsecure/cybertruckchallenge19)
  * CyberTruck Challenge 22: [https://github.com/nowsecure/cybertruckchallenge22](https://github.com/nowsecure/cybertruckchallenge22)
  * Belkasoft CTF: with a focus on mobile forensics [https://belkasoft.com/ctf](https://belkasoft.com/ctf)
</details>

## Automation & Systems Administration

* [AlgoVPN: Custom VPN Deployment Solutions](https://github.com/trailofbits/algo)
* [How to create VPN on a VPS with Ubuntu](https://www.host-telecom.com/guides/how-to-create-vpn-on-a-vps-with-ubuntu/)
* [hackingtutorials.org article on setting up penetration testing tools on a VPS/dedicated server](https://www.hackingtutorials.org/general-tutorials/penetration-testing-cloud/)
* [AutoSploit tool by "NullArray"](https://github.com/NullArray/AutoSploit)
* [Go Beyond Google: The Best Alternative Search Engines](https://www.pcmag.com/picks/go-beyond-google-best-alternative-search-engines)
  * In our opinion, good alternatives to Google Search are: [DuckDuckGo](https://duckduckgo.com/), [Presearch](https://presearch.com/), [Microsoft Bing](https://www.bing.com), and (maybe) [Yahoo! Search](https://search.yahoo.com/).

<details>
 <summary>Programming Tidbits</summary>

 * [opensource.com: You don't know Bash: An introduction to Bash arrays](https://opensource.com/article/18/5/you-dont-know-bash-intro-bash-arrays)
 * [How to create a Python library](https://medium.com/analytics-vidhya/how-to-create-a-python-library-7d5aea80cc3f)
 * [Setup a python script as a service through systemctl/systemd](https://medium.com/codex/setup-a-python-script-as-a-service-through-systemctl-systemd-f0cc55a42267)
</details>

<details>
 <summary>Metasploit Setup and Configuration</summary>
 
  * [Fedora Project's Wiki Entry on Metasploit PostgreSQL Setup](https://fedoraproject.org/wiki/Metasploit_Postgres_Setup)
  * [Run Metasploit Framework as a Docker Container Without Installation Pains](https://zeltser.com/metasploit-framework-docker-container/)
  * [miteshshah.github.io: How to Fix Metasploit Database Not Connected or Cache Not Built](https://miteshshah.github.io/linux/kali/how-to-fix-metasploit-database-not-connected-or-cache-not-built/)
  * [Rapid7 article: No Database Connection](https://docs.rapid7.com/metasploit/no-database-connection/)
  * [Rapid7 article: Uninstalling Metasploit](https://docs.rapid7.com/metasploit/uninstalling-metasploit/)
  * [Kali Linux article discussing setting up Metasploit](https://www.kali.org/docs/tools/starting-metasploit-framework-in-kali/)
  * [A SecList thread discussing how to (hopefully) fix errors with the ``auxiliary/scanner/http/crawler`` module](https://seclists.org/metasploit/2011/q1/74)
    
</details>

## Machine Learning

* [DataCamp's Association Rule Mining in Python Tutorial](https://www.datacamp.com/tutorial/association-rule-mining-python)

## Academic Publications

<details>
   <summary>Digital Forensics and Incident Response</summary>

   * [Integrity, authenticity, non-repudiation, and proof of existence for long-term archiving: A survey](https://www.sciencedirect.com/science/article/abs/pii/S0167404814001849)
</details>

<details>
 <summary>Psychoinformatics and Data Science in Cybersecurity</summary>
 
 * [Digital Phenotyping and Mobile Sensing: New Developments in Psychoinformatics](https://link.springer.com/book/10.1007/978-3-030-31620-4)
 * [Data Analysis in Forensic Science: A Bayesian Decision Perspective](https://www.wiley.com/en-ca/Data+Analysis+in+Forensic+Science%3A+A+Bayesian+Decision+Perspective-p-9780470998359)
</details>

<details>
 <summary>Exploit Development</summary>

 * [AEG: Automatic Exploit Generation (Avgerinos et al.)](https://security.ece.cmu.edu/aeg/aeg-current.pdf)
 * [Toward an Automatic Exploit Generation Competition for an Undergraduate Binary Reverse Engineering Course (OConnor et al.)](https://raw.githubusercontent.com/tj-oconnor/Publications/main/pdf/iticse2022oconnor.pdf)
 * [Automatic Heap Layout Manipulation for Exploitation (Heelan et al 2019)](https://www.usenix.org/conference/usenixsecurity18/presentation/heelan)
 * [Automatic Patch-Based Exploit Generation is Possible: Techniques and Implications](http://bitblaze.cs.berkeley.edu/papers/apeg.pdf)
</details>

## Other Awesome Resources

<details>
 <summary>Awesome Twitter/X Posts</summary>

 * [A list of Bug Bounty Platforms](https://twitter.com/hetmehtaa/status/1735023393211302112)
</details>

<details>
 <summary>Awesome list of security firms/organizations</summary>

 * ManTech: https://www.mantech.com/
 * Immunity Inc: https://immunityinc.com/
 * Core Security: https://www.coresecurity.com/
 * Cobalt Labs: https://www.cobalt.io/
     * Not to be confused with [Cobalt Strike](https://www.cobaltstrike.com/) ;-)
 * HBGary (now defunct): http://web.archive.org/web/20120504003249/http://www.hbgary.com/
 * Mandiant: https://www.mandiant.com/
 * MAGNET Forensics: https://www.magnetforensics.com/
 * CrowdStrike: https://www.crowdstrike.com/en-us/
 * Kaspersky: https://usa.kaspersky.com/
 * Rapid7: https://www.rapid7.com/
 * Booz Allen Hamilton: https://www.boozallen.com/
     * Note that [this firm is a bit sus](https://en.wikipedia.org/wiki/Booz_Allen_Hamilton#Controversies_and_leaks), but they do interesting work nonetheless.
 * DarkTrace Security: https://darktrace.com/
 * Tenable: https://www.tenable.com/
 * Fortinet: https://www.fortinet.com/
 * Cellebrite: https://cellebrite.com/en/home/
     * Note that [this firm is a bit sus](https://www.accessnow.org/what-spy-firm-cellebrite-cant-hide-from-investors/), but they do interesting work nonetheless.
  * Belkasoft: https://belkasoft.com/
  * GoSecure (previously CounterTack): https://www.gosecure.net/

 This list borrows from [ESecurityPlanet.com](https://www.esecurityplanet.com/products/top-cybersecurity-companies/) to some extent.  
</details>

<details>
   <summary>Awesome GitHubs</summary>

   * [Awesome Machine Learning for Cyber Security](https://github.com/jivoi/awesome-ml-for-cybersecurity)
   * [Awesome Shodan Search Queries](https://github.com/jakejarvis/awesome-shodan-queries)
   * [Awesome Censys Queries](https://github.com/thehappydinoa/awesome-censys-queries)
   * [Awesome List of Exploit Development Resources](https://github.com/cranelab/exploit-development)
   * [Awesome CTF Checklist by "ZeroDayTea"](https://github.com/ZeroDayTea/CTF-Checklist)
   * [Awesome Bug Bounty checklist/toolkit list/public programme list by "sehno"](https://github.com/sehno/Bug-bounty/)
   * [Awesome Bug Bounty cheatsheet by "m0chan"](https://m0chan.github.io/2019/12/17/Bug-Bounty-Cheetsheet.html)
</details>

<details>
 <summary>Awesome CTF/Bug Bounty GitBooks</summary>

 * Bug Hunter Handbook by "gowthams:" [https://gowthams.gitbook.io/](https://gowthams.gitbook.io/)
 * CTF Playbook by "fareedfauzi:" [https://fareedfauzi.gitbook.io/ctf-playbook/](https://fareedfauzi.gitbook.io/ctf-playbook/)
 * HackTricks: [https://book.hacktricks.xyz/](https://book.hacktricks.xyz/)
 * Oh Shint!: [https://ohshint.gitbook.io/oh-shint-its-a-blog/](https://ohshint.gitbook.io/oh-shint-its-a-blog/)
 * The Hacker Playbook: [https://www.thehacker.recipes](https://www.thehacker.recipes)
</details>
