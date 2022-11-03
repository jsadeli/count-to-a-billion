<?php
echo "Hello, world!\n";
$start = microtime(true);

$i = 0;
while ($i < 1_000_000_000) {
  $i++;
}

$stop = microtime(true);
$duration = $stop - $start;
echo "duration $duration sec\n";
echo "i=$i\n";
?>
