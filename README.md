1. Po utworzeniu brancha feature-max, na glownym branchu main pojawil sie nowy niezalezny commit z plikiem README i to uniemozliwilo Gitowi proste przewiniecie historii do przodu i wymusilo na nim polaczenie tych rozgalezien za pomoca innego merge.

(KOMENTARZ POD REBASE czy cos)

2. Kiedy uzywamy merge Git laczy dwa niezalezne branche tworzac nowy commit przez co w historii projektu zostaje wtedy widoczny slad rozwidlenia i zlaczeni branchu. Natomiast rebase to operacje ktora zrywa commity z branchy bocznych i przenosi je na sam czubek maina dzieki czemu historia zostaje liniowa. Dlatego programisci preferuja rebase poniewaz taka historia jest latwiejsza to odczytania i ulatwia sprawdzanie kodu, choc przepisuje on historie commitow.

3. Gdy wystapil konflikt kliknalem w przycisk "resolve conflict" (albo cos podobnego nie pamietam) po czym mialem zaprezentowane 3 okna z 3 roznymi rozwiazaniami, println po Angielsku, po Polsku oraz po Albansku. Wystarczylo, ze kliknalem odrzuc 2 razy (na srodku bylo rozwiazanie po Angielsku co mi najbardziej odpowiadalo) i konflikt zostaw rozwiazany. Zrobilem po tym git commit -m oraz git push.