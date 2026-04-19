(ns cars-assemble)

(def base-speed-cars 221)

(defn production-rate
  "Returns the assembly line's production rate per hour,
   taking into account its success rate"
  [speed]
  (cond
    (== speed 0) 0
    (<= speed 4) (* base-speed-cars speed)
    (<= speed 8) (* 0.9 (* base-speed-cars speed))
    (== speed 9) (* 0.8 (* base-speed-cars speed))
    (== speed 10) (* 0.77 (* base-speed-cars speed)))
  )

(defn working-items
  "Calculates how many working cars are produced per minute"
  [speed]
  (int (/ (production-rate speed) 60))
  )
