(ns cars-assemble)

(def base-speed-cars 221)

(defn production-rate
  "Returns the assembly line's production rate per hour,
   taking into account its success rate"
  [speed]
  (let [cars-made-at-speed (* base-speed-cars speed)]
    (cond
      (= speed 0) 0
      (<= speed 4) cars-made-at-speed
      (<= speed 8) (* 0.9 cars-made-at-speed)
      (= speed 9) (* 0.8 cars-made-at-speed)
      (= speed 10) (* 0.77 cars-made-at-speed)))
  )

(defn working-items
  "Calculates how many working cars are produced per minute"
  [speed]
  (int (/ (production-rate speed) 60))
  )
