
## Penetration Testing (TryHackMe)

1. Recon
    1. Search Engine
        1. Google Search (general search engine)
        2. Bing Search (good alternative)
        3. Yandex Search (another good alternative)
        4. Shodan (the "Google" for IoT devices and servers)
        5. Censys (alternative to Shodan)
    2. [...]
2. Enumeration
    1. nmap 
        1. TCP scan: ``-sT -A -v <ip address> -Pn -p- -O -oX <tcp_scan.xml> <optional -Pn>``
        2. SYN scan: ``-sS -A -v <ip address> -Pn -p- -O -oX <syn_scan.xml> <optional -Pn>``
        3. FIN Scan: ``-sF -v <ip address> -Pn -p- -oX <fin_scan.xml>``
    2. Web Hacking
        1. consult the OWASP framework
        2. use Nikto to probe the web app
        3. use Burp Suite to probe the web app
        4. Fuzz URLs with DirBuster
        5. If applicable, brute force any logins with ``hydra``, ``john`` and ``/usr/share/wordlists``
3. Exploitation
4. Post-Exploitation
5. Looting

## Reverse Engineering (THM)

## Digital Forensics and Incident Response (*ahem* THM)
