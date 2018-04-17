using UnityEngine;
using System.Collections;

public class Test: MonoBehaviour{
    
    void Start(){
        
        int[] array = {1,2,3,4,5};
        
        for (int i=0; i<array.Length; i++){
            
                Debug.Log(array[i]);
                }
                
        for (int n=4; n>=0; n--){
            
               Debug. Log(array[n]);
    
		}
		Boss lastboss=new Boss();
		
		for (int i=1; i<=11; i++){
			lastboss.Magic(5);
			}
    }
    }
    
public class Boss{
    public int mp = 53;
    public void Magic(int damage){
        if (mp>=damage){
        	mp-=damage;

        Debug.Log("魔法攻撃をした。残りMPは"+mp);
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
    
    
}