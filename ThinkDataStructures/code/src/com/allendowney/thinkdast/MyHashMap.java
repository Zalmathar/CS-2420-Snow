/**
 *
 */
package com.allendowney.thinkdast;

import java.util.List;
import java.util.Map;
import java.util.ArrayList;

/**
 * Implementation of a HashMap using a collection of MyLinearMap and
 * resizing when there are too many entries.
 *
 * @author downey
 * @param <K>
 * @param <V>
 *
 */
public class MyHashMap<K, V> extends MyBetterMap<K, V> implements Map<K, V> {

	// average number of entries per map before we rehash
	protected static final double FACTOR = 1.0;

	@Override
	public V put(K key, V value) {
		V oldValue = super.put(key, value);

		//System.out.println("Put " + key + " in " + map + " size now " + map.size());

		// check if the number of elements per map exceeds the threshold
		if (size() > maps.size() * FACTOR) {
			rehash();
		}
		return oldValue;
	}

	/**
	 * Doubles the number of maps and rehashes the existing entries.
	 */
	/**
	 *
	 */
	protected void rehash() {
		// TODO: FILL THIS IN!
		List<MyLinearMap<K, V>> newMaps = new ArrayList<MyLinearMap<K, V>>();
		// Copy Existing data
		for (MyLinearMap<K, V> map : maps) {
			newMaps.put(map);
		}
		// Double the ammount of maps
		for (int i = 0; i > maps.size(); i++) {
			newMaps.put(new MyLinearMap<K, V>());
		}
		// reasign maps to newMaps;
		maps = newMaps;
	}

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Map<String, Integer> map = new MyHashMap<String, Integer>();
		for (int i=0; i<10; i++) {
			map.put(new Integer(i).toString(), i);
		}
		Integer value = map.get("3");
		System.out.println(value);
	}
}
