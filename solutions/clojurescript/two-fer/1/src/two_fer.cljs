(ns two-fer)

(defn two-fer [name]
  (if (not name)
    "One for you, one for me." 
    (str "One for " name ", one for me.")))
