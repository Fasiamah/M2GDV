# Coneptschets
Title: Reverse Busters
Genre: Physics-based arcade shootergame
# Beschrijfing
De speler schiet een bal naar de muur. Die muur weerkaatst de bal. Die bal moet proberen om de tegenstanders achter de speler te raken. Elke keer dat je een grote tegenstander raakt, krijg je 10 punten. bij elke kleine tegenstander krijg je 20 punten. als je 2 tegenstanders raakt, krijg je een double kill en krijg je dubbel de punten (bijvoorbeeld als je 2 kleine tegenstanders raakt krijg je 60 punten inplaats van 20) als ze je pakken, krijg je een game over scherm te zien.
# Gameplaykern
- speler (een canon van de bovenperspectief
- enemy (een groene zombie voor de kleine, en een groen/gele zombie voor de grote)
- de bal (een vuurbal)
- de weerkaatsende muur (een muur dat op en neer gaat)
- achtergrond (gras)
- doel (proberen om zo veen mogelijk zombies neer te schieten)
# Stijl en sweer
cartoon. energieke achtergrond muziek met sound effects voor de zombies
# structuur van het spel
- links (het weerkaatsende muur)
- midden (de speler)
- rechts (de zombies die naar jouw toe lopen)

# 2.1 wat heb ik deze week gedaan?
![M2GDV_BallCollider+Hit!](https://github.com/user-attachments/assets/3e966ac4-7c99-4e2c-8890-48b1b8f35cfc)
ik heb deze week gewerkt met AddForce. je kan de bal laten bewegen door op a te kli!
kken. Ik heb ook een OnCollisionEnter toegevoegd, en een ridgit body+collider.

verder had ik geen moeite 

# Opdracht 1A
Hier heb ik een array gemaakt, waneer je op a klikt, krijg je een verschilende Element 
![M2GDV_Array](https://github.com/user-attachments/assets/6d049d4b-5d10-44b3-81c8-54f88da96557)

```C#

using UnityEngine;

public class RandomItems : MonoBehaviour
{
    //een lijst(array) maken
    [SerializeField]
    internal string[] fish = new string[9];

    private void Start()
    {
        Debug.Log(fish[2]);
    }
    void iets()
    {
        int boon = Random.Range(0,fish.Length);

        Debug.Log(fish [boon]);
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A)) {
            iets();
        }

    }
}

```
